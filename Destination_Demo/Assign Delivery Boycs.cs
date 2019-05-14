using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;
namespace Destination_Demo
{
    public partial class Assign_Delivery_Boy : Form
    {
        AdminNewOrder back;
        LogIn l;
        int OrderId;
        AdminDashBoard dash;
        string rloc, ploc;
        string dbID;
        DataGridView dg;
        public Assign_Delivery_Boy(AdminNewOrder a, int id, AdminDashBoard dash, LogIn i, string p, string r, DataGridView dg)
        {
            this.back = a;
            this.l = i;
            this.OrderId = id;
            this.dash = dash;
            this.rloc = r;
            this.ploc = p;
            this.dg = dg;
            InitializeComponent();
            this.richTextBox1.Text = ploc;
            this.richTextBox2.Text = rloc;
            DataBase db = new DataBase();
            DataTable dt = db.Get_DeliveryBoy_Details();
            this.DeliveryBoyGrid.DataSource = dt;
        }

        private void Assign_Delivery_Boycs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Assign_Delivery_Boycs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dt = db.get_Sender_Details();
            // this.dg.DataSource = dt;
            Application.Exit();
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void searchbox_KeyUp(object sender, KeyEventArgs e)
        {
            if(this.catagory.Text=="")
            {
                this.Error.Visible = true;
            }
            else
            {
                this.Error.Visible = false;
                if(this.catagory.Text=="City")
                {
                    //MessageBox.Show(this.searchbox.Text);
                    DataBase db = new DataBase();
                    DataTable dt=db.Get_DeliveryBOY_City(this.searchbox.Text);
                    DeliveryBoyGrid.DataSource = dt;
                }
            }
        }

        private void catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(catagory.Text=="All List")
            {
                DataBase db = new DataBase();
                DataTable dt = db.Get_DeliveryBoy_Details();
                this.DeliveryBoyGrid.DataSource = dt;
            }
        }

        private void DeliveryBoyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.RowIndex<DeliveryBoyGrid.RowCount-1)
            {
                DataGridViewRow dt = DeliveryBoyGrid.Rows[e.RowIndex];
                this.dbID = dt.Cells[0].Value.ToString();
                this.AssignBtn.Visible = true;
            }
            else
            {
                this.AssignBtn.Visible = false;
            }
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if(db.Update_Order(this.OrderId, this.dbID))
            {
                db = new DataBase();
                DataTable dt = db.Get_DeliveryBoy_Details();
                MessageBox.Show("Assigned Successfully");
                back.Show();
                back.ClearFields();
                back.ReloadData();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }
    }
}

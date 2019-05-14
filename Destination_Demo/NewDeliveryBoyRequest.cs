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
    public partial class NewDeliveryBoyRequest : Form
    {
        AdminDashBoard par;
        LogIn l;
        DataTable dt=new DataTable();
        int id;
        public NewDeliveryBoyRequest(AdminDashBoard p,LogIn i)
        {
            this.par = p;
            this.l = i;
            InitializeComponent();

        }

        private void NewDeliveryBoyRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewDeliveryBoyRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            par.Show();
            par.ReloadData();
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void DBRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.RowIndex<DBRequest.RowCount-1)
            {
                DataGridViewRow dt = DBRequest.Rows[e.RowIndex];
                id = (int)dt.Cells[0].Value;
                this.AddBtn.Visible = true;
                this.DltButton.Visible = true;
            }
            else
            {
                this.AddBtn.Visible = false;
                this.DltButton.Visible = false;
            }
        }

        private void ToggleButtons()
        {
            AddBtn.Visible = DltButton.Visible = dt.Rows.Count != 0;
        }

        private void DltButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.delete_TMP_Request(this.id);
            //Data db = new DataBase();
            this.ReloadData();
            ToggleButtons();
        }
        public void ReloadData()
        {
            DataBase db = new DataBase();
            dt = db.Get_NewDBRequest();
            this.DBRequest.DataSource = dt;
            ToggleButtons();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dt=db.Select_TmpRequest(id);
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("No New Request Left");
                return;
            }
            string fname = dt.Rows[0][1].ToString();
            string sname= dt.Rows[0][2].ToString();
            string ph = dt.Rows[0][3].ToString();
            string em = dt.Rows[0][4].ToString();
            string pass = dt.Rows[0][5].ToString();
            string floc = dt.Rows[0][6].ToString();
            string sloc = dt.Rows[0][7].ToString();
            if(db.AddDeliveryBoy(fname, sname, ph, em, pass, floc, sloc))
            {
                MessageBox.Show("DeliveryBoy Added Successfully\n");
                db.delete_TMP_Request(this.id);
            }
            this.ReloadData();
            ToggleButtons();
        }

        private void NewDeliveryBoyRequest_Shown(object sender, EventArgs e)
        {
            this.ReloadData();
        }
    }
}

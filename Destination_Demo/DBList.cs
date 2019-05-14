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
    public partial class DBlist : Form
    {
        AdminDashBoard dash;
        LogIn l;
        string dltid;
        int logdltid;
        public DBlist(AdminDashBoard d,LogIn l)
        {
            dash = d;
            this.l = l;
            InitializeComponent();
            DataBase db = new DataBase();
            DataTable dt = db.Get_All_DeliveryBoy();
            this.dbgrid.DataSource = dt;
        }

        private void catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(catagory.Text=="AllList")
            {
                this.SearchBox.ReadOnly = true;
                DataBase db = new DataBase();
                DataTable dt=db.Get_All_DeliveryBoy();
                this.dbgrid.DataSource = dt;
            }
            else
            {
                this.SearchBox.ReadOnly = false;
            }
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void dbgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dbgrid.RowCount - 1)
            {
                DataGridViewRow dt = dbgrid.Rows[e.RowIndex];
                dltid = dt.Cells[0].Value.ToString();
                logdltid = (int)dt.Cells[8].Value;
                this.dltbutton.Visible = true;
            }
            else
                this.dltbutton.Hide();
        }

        private void DBlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DBlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(catagory.Text=="")
            {
                slabel.Visible = true;
            }
            else
            {
                slabel.Visible = false;
                if(catagory.Text=="City")
                {
                    DataBase db = new DataBase();
                    DataTable d=db.Get2_DeliveryBoy_City(this.SearchBox.Text);
                    this.dbgrid.DataSource = d;
                }
                else if(catagory.Text=="Name")
                {
                    DataBase db = new DataBase();
                    DataTable dt = db.Get_DeliveryBoy_Name(this.SearchBox.Text);
                    this.dbgrid.DataSource = dt;
                }
                else if(catagory.Text=="ID")
                {
                    DataBase db = new DataBase();
                    DataTable dt = db.Get_DeliveryBoy_ID(this.SearchBox.Text);
                    this.dbgrid.DataSource = dt;
                }

            }
        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if(db.Delete_DeliveryBoy(dltid, logdltid))
            {
                MessageBox.Show("Deleted Successfully");
                DataTable dt = db.Get_All_DeliveryBoy();
                this.dbgrid.DataSource = dt;
                dltbutton.Hide();

            }
        }
    }
}

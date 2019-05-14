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
    public partial class RequestForm : Form
    {
        LogIn l;
        DeliverDashboard dash;
        int id;
        int orderid;
        public RequestForm(DeliverDashboard d,LogIn i,int iss)
        {
            this.l = i;
            this.dash = d;
            this.id = iss;
            InitializeComponent();
        }

        private void RequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void RequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Reload()
        {
            DataBase db = new DataBase();
            string s = "D";
            s += id.ToString();
            DataTable dt= db.Get_Order_Details(s);
            this.Request.DataSource = dt;
            this.RCVName.Text =string.Empty;
            this.RCVPhone.Text =string.Empty;
            this.RCVLoc.Text = string.Empty;
            this.Cmpltbtn.Hide();
        }

        private void RequestForm_Shown(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
            dash.RefreshPage();
            Cmpltbtn.Hide();
            
        }

        private void Request_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.RowIndex<Request.RowCount-1)
            {
                Cmpltbtn.Show();
                DataGridViewRow dt = Request.Rows[e.RowIndex];
                orderid = (int)dt.Cells[0].Value;
                DataTable dtt = new DataTable();
                DataBase db = new DataBase();
                dtt = db.Get_OrderR_Details(orderid);
                this.RCVName.Text = dtt.Rows[0][0].ToString();
                this.RCVLoc.Text = dtt.Rows[0][1].ToString();
                this.RCVPhone.Text = dtt.Rows[0][2].ToString();

            }
            else
            {
                Cmpltbtn.Hide();
            }
        }

        private void Cmpltbtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if(db.Done_Order(orderid))
            {
                this.Reload();
                MessageBox.Show("Good Job!!!");
                
            }
            else
            {
                MessageBox.Show("Try Again Letter!!!");
            }
        }
    }
}

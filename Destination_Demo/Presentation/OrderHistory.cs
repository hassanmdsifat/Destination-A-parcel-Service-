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
    public partial class OrderHistory : Form
    {
        MemberDashBoard par;
        LogIn l;
        string userid;
        public OrderHistory(MemberDashBoard m,LogIn i,string s)
        {
            this.par = m;
            this.l = i;
            this.userid = s;
            DataBase db = new DataBase();
            DataTable dt = db.Get_User_OrderHistory(userid);
            InitializeComponent();
            OrderHistoryGrid.DataSource = dt;
        }

        private void OrderHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrderHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.par.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.l.Show();
        }

        private void OrderHistoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex>=0&&e.RowIndex<OrderHistoryGrid.RowCount-1)
            {
                DataGridViewRow dt = OrderHistoryGrid.Rows[e.RowIndex];
                RCVname.Text = dt.Cells[1].Value.ToString();
                RCVPhone.Text = dt.Cells[3].Value.ToString();
                Addressbox.Text = dt.Cells[2].Value.ToString();
                int orderID = (int)dt.Cells[0].Value;
                string pt="", add="";
                DataBase db = new DataBase();
                db.GetOrder_Type(orderID, out pt, out add);
                OrderType.Text = pt;
                AddInfo.Text = add;
                string dbID=db.Get_DeliveryBoyId(orderID);
                if(dbID!="")
                {
                    string name,phone;
                    db.Get_DelieryBoyDetails(dbID, out name, out phone);
                    this.DBname.Text = name;
                    this.DBPhone.Text = phone;
                }
                else
                {
                    this.DBname.Text = "";
                    this.DBPhone.Text = "";
                }
            }
           else
            {
                RCVname.Text = "";
                RCVPhone.Text = "";
                Addressbox.Text = "";
                this.DBname.Text = "";
                this.DBPhone.Text ="";
                OrderType.Text = "";
                AddInfo.Text = "";
            }
        }
    }
}

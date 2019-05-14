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
    public partial class AdminDashBoard : Form
    {
        LogIn par;
        DataTable NewOrder = new DataTable();
        public AdminDashBoard(LogIn p)
        {
            this.par = p;
            InitializeComponent();

        }
        public void ReloadData()
        {
            DataBase db = new DataBase();

            NewOrder = db.get_newOrder();
            if (NewOrder.Rows.Count != 0)
            {
                this.NewOrderButton.BackColor = Color.Red;
            }
            else
            {
                this.NewOrderButton.BackColor = Color.LimeGreen;
            }
            DataTable dt = db.Get_NewDBRequest();
            if (dt.Rows.Count == 0)
            {
                this.NewDBRequest.BackColor = Color.LimeGreen;
            }
            else
            {
                this.NewDBRequest.BackColor = Color.Red;
            }
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            par.Show();
        }

        private void AdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminNewOrder n = new AdminNewOrder(this, par);
            n.Show();
        }

        private void NewDBRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewDeliveryBoyRequest db = new NewDeliveryBoyRequest(this, par);
            db.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBlist d = new DBlist(this, par);
            d.Show();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            AdminOrderStatus n = new AdminOrderStatus(this, par);
            n.Show();
            this.Hide();

        }

        private void UserListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllUser n = new ViewAllUser(this, par);
            n.Show();
        }

        private void AdminDashBoard_Shown(object sender, EventArgs e)
        {
            this.ReloadData();
        }
    }
}

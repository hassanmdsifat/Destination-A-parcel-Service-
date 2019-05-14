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
    public partial class AdminOrderStatus : Form
    {
        LogIn l;
        AdminDashBoard dash;
        public AdminOrderStatus(AdminDashBoard d,LogIn i)
        {
            l = i;
            dash = d;
            InitializeComponent();
            DataBase db = new DataBase();
            this.OrderGrid.DataSource=db.get_AllOrder();

        }

        private void AdminOrderStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminOrderStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }
    }
}

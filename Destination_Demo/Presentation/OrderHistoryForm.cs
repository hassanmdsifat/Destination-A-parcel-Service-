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
    public partial class OrderHistoryForm : Form
    {
        DeliverDashboard dash;
        LogIn l;
        int id;
        public OrderHistoryForm(DeliverDashboard d,LogIn s,int id)
        {
            this.dash = d;
            this.l = s;
            this.id = id;
            InitializeComponent();
        }
        private void Reload()
        {
            DataBase db = new DataBase();
            DataTable dt= db.Get_All_Order(this.id);
            this.OrderDetailsGrid.DataSource = dt;
        }
        private void OrderHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void OrderHistoryForm_Shown(object sender, EventArgs e)
        {
            this.Reload();
        }
    }
}

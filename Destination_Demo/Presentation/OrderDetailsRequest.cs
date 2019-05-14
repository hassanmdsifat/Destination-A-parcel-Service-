using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destination_Demo
{
    public partial class OrderDetailsRequest : Form
    {
        DeliverDashboard dash;
        public OrderDetailsRequest(DeliverDashboard d)
        {
            dash = d;
            InitializeComponent();
        }

        private void OrderDetailsRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrderDetailsRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void UserLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn n = new LogIn(new WelcomePage());
            n.Show();
        }
    }
}

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
    public partial class ConfirmOrder : Form
    {
        //private PlaceOrder3 parent;
        private MemberDashBoard dash;
        private LogIn l;
        private OrderHistory back;
        public ConfirmOrder(OrderHistory p,MemberDashBoard m,LogIn l,int id)
        {
            //this.o = t;
            this.back = p;
            this.dash = m;
            this.l=l;
            InitializeComponent();
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void ConfirmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }
    }
}

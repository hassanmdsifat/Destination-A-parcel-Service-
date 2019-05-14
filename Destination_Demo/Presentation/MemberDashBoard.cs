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
    public partial class MemberDashBoard : Form
    {
        private LogIn l;
        private int id;
        public MemberDashBoard(LogIn p,int e)
        {
            this.l = p;
            this.id= e;
            InitializeComponent();
        }

        private void MemberDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserLogout_Click(object sender, EventArgs e)
        {
            if(l!=null)
            {
                l.Show();
            }
            this.Hide();
        }

        private void UserNotificationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification s = new Notification(this,l);
            s.Show();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceOrder1 p1 = new PlaceOrder1(this, l, this.id) ;
            p1.Show();
        }

        private void UserHistoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string id = "U";
            id += this.id.ToString();
            OrderHistory H = new OrderHistory(this,l,id);
            H.Show(); 
        }
    }
}

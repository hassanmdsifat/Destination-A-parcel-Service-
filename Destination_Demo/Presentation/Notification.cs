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
    public partial class Notification : Form
    {
        MemberDashBoard m;
        LogIn l;
        public Notification(MemberDashBoard m1,LogIn l1)
        {
            this.m = m1;
            this.l = l1;
            InitializeComponent();
        }

        private void NotiDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            m.Show();
        }

        private void NotiLoogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }
    }
}

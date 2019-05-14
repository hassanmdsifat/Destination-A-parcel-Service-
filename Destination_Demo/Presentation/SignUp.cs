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
    public partial class SignUp : Form
    {
        private WelcomePage w1;
        void GoBack()
        {
            if(w1!=null)
            {
                w1.Show();
            }
            this.Hide();
        }
        public SignUp(WelcomePage w)
        {
            this.w1 = w;
            InitializeComponent();
        }

        private void SignUpBack_Click(object sender, EventArgs e)
        {
            this.GoBack();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpDelveryboy_Click(object sender, EventArgs e)
        {
            SignUpDeliveryBoy s1 = new SignUpDeliveryBoy(this);
            s1.Show();
            this.Hide();
        }

        private void SignUpUser_Click(object sender, EventArgs e)
        {
            SignUpUser s1 = new SignUpUser(this,new LogIn(w1));
            s1.Show();
            this.Hide();
        }
    }
}

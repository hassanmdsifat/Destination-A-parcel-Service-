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
    public partial class LogIn : Form
    {
        private WelcomePage w1;
        public LogIn(WelcomePage w)
        {
            this.w1 = w;
            InitializeComponent();
        }
        private void GoBack()
        {
            if(this.w1!=null)
            {
                w1.Show();
            }
            this.Hide();
        }

        private void LoginBack_Click(object sender, EventArgs e)
        {
            this.GoBack();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserLogInbutton_Click(object sender, EventArgs e)
        {
            string uname = UsernameTextbox.Text;
            string pass = PasswordUserTextbox.Text;
            //MessageBox.Show(uname);
            if(uname==""&&pass=="")
            {
                MessageBox.Show("Username And Password Fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(uname=="")
            {
                MessageBox.Show("Username Field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pass=="")
            {
                MessageBox.Show("Password Field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Temporary Fix
                //MemberDashBoard m = new MemberDashBoard(this,)
                DataBase db = new DataBase();
                int id;
                string status;
                Logic lo = new Logic();
                string hashpass=lo.hash1(pass).ToString();
                string s = db.Check_Who(uname, hashpass,out id,out status);
                ///MessageBox.Show("Username: " + s + " ID: " + id);
                if(s=="U"&&status=="Y")
                {
                    MemberDashBoard m = new MemberDashBoard(this,id);
                    m.Show();
                    this.Hide();
                }
                else if(s=="A"&&status=="Y")
                {
                    AdminDashBoard n = new AdminDashBoard(this);
                    n.Show();
                    this.Hide();
                }
                else if(s=="D"&&status=="Y")
                {
                    DeliverDashboard d = new DeliverDashboard(this,id);
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Id Or Password","Errror");
                }
                //m.Show();
                //
            }
        }

        private void LogIn_Shown(object sender, EventArgs e)
        {
            this.UsernameTextbox.Text = "";
            this.PasswordUserTextbox.Text = "";
        }
    }
}

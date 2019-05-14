using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseConnection;

namespace Destination_Demo
{
    public partial class SignUpUser : Form
    {
        private SignUp P;
        private LogIn l;
        const string constr = "Data Source=DESKTOP-CAOLCCP;Initial Catalog=DESTINATION;Integrated Security=True";
        SqlConnection sql = new SqlConnection(constr);
        public SignUpUser(SignUp p,LogIn l)
        {
            this.P = p;
            this.l = l;
            InitializeComponent();
        }
        private void SignUpUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void GoBack()
        {
            if (P != null)
            {
                P.Show();
            }
            this.Hide();
        }
        private bool checkOK()
        {
            if(this.UserFirstName.Text!=string.Empty&&Logic.ReturnOK(this.UserFirstName.Text)&&this.UserLastName.Text!=string.Empty&&Logic.ReturnOK(this.UserLastName.Text)&&
                this.UserEmail.Text!=string.Empty&&Logic.IsEmailValid(this.UserEmail.Text)&&Logic.ReturnOK(this.UserEmail.Text)&&this.UserPhoneNumber.Text!=string.Empty&&Logic.Check_Number(this.UserPhoneNumber.Text)&&
                this.UserPassword.Text!=string.Empty&&Logic.ReturnOK(this.UserPassword.Text)&&this.UserPassword.Text==this.UserRPassword.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UserBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void UserSignIn_Click(object sender, EventArgs e)
        {
            string s;
            if(this.checkOK())
            {
                //string id = "00";
                DataBase db = new DataBase();
                if (db.Email_Verification(this.UserEmail.Text))
                {
                    this.Hide();
                    Logic lo = new Logic();
                    string passhash = lo.hash1(this.UserPassword.Text).ToString();
                    db.AddUser(this.UserFirstName.Text, this.UserLastName.Text, this.UserPhoneNumber.Text, this.UserEmail.Text, passhash);

                    int id;
                    string status;
                   
                    //MessageBox.Show(passhash);
                    string st = db.Check_Who(this.UserEmail.Text, passhash, out id, out status);
                    //User u1 = new User(id,this.UserFirstName.Text, this.UserLastName.Text, this.UserPhoneNumber.Text, this.UserEmail.Text);
                    MemberDashBoard m1 = new MemberDashBoard(l, id);
                    m1.Show();
                }
                else
                {
                    MessageBox.Show("User Already Exist!!!");
                }
            }
            else
            {
                MessageBox.Show("Fill Up The Form Properly!!!");
            }
        }

        private void UserPassword_Leave(object sender, EventArgs e)
        {
          if(UserPassword.Text==string.Empty)
            {
                this.Passemp.Show();
            }
          else
            {
                this.Passemp.Hide();
            }
            if (Logic.ReturnOK(this.UserPassword.Text))
            {
                this.Passvld.Hide();
            }
            else
                this.Passvld.Show();

        }

        private void UserFirstName_Leave(object sender, EventArgs e)
        {
            if(this.UserFirstName.Text==string.Empty)
            {
                this.FnameVal.Show();
            }
            else
            {
                this.FnameVal.Hide();
            }
            if(Logic.ReturnOK(this.UserFirstName.Text))
            {
                this.FnameErr.Hide();
            }
            else
            {
                this.FnameErr.Show();
            }
        }

        private void UserLastName_Leave(object sender, EventArgs e)
        {
            if (this.UserLastName.Text == string.Empty)
            {
                this.LnameVal.Show();
            }
            else
            {
                this.LnameVal.Hide();
            }
            if (Logic.ReturnOK(this.UserLastName.Text))
            {
                this.LnameErr.Hide();
            }
            else
            {
                this.LnameErr.Show();
            }
        }

        private void UserPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (this.UserPhoneNumber.Text == string.Empty)
            {
                this.PhEmpty.Show();
            }
            else
            {
                this.PhEmpty.Hide();
            }
            if (Logic.Check_Number(UserPhoneNumber.Text))
            {
                this.PHvalid.Hide();
            }
            else
            {
                this.PHvalid.Show();
            }
        }

        private void UserEmail_Leave(object sender, EventArgs e)
        {
            if (this.UserEmail.Text == string.Empty)
            {
                this.EmailErr.Show();
            }
            else
            {
                this.EmailErr.Hide();
            }
            if(Logic.IsEmailValid(this.UserEmail.Text))
            {
                this.Emailvld.Hide();
            }
            else
            {
                this.Emailvld.Show();
            }
        }

        private void UserRPassword_Leave(object sender, EventArgs e)
        {
            if(this.UserPassword.Text!=this.UserRPassword.Text)
            {
                this.Rpasserr.Show();
            }
            else
            {
                this.Rpasserr.Hide();
            }
        }
    }
}

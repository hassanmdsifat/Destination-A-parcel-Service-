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
    public partial class SignUpDeliveryBoy : Form
    {
        private SignUp s;
        public SignUpDeliveryBoy(SignUp st)
        {
            this.s = st;
            InitializeComponent();
        }
        bool check_Fields()
        {
            if (this.DBFname.Text != string.Empty && Logic.ReturnOK(DBFname.Text) && this.DBLname.Text != string.Empty && Logic.ReturnOK(this.DBLname.Text) &&
                Logic.Check_Number(this.DBPhone.Text) && Logic.IsEmailValid(this.DBEmail.Text) && this.DBPass.Text != string.Empty && Logic.ReturnOK(this.DBPass.Text) &&
                this.DBPass.Text == this.DBRpass.Text && this.DBFloc.Text != string.Empty && this.DBSloc.Text != string.Empty)
                return true;
            else
                return false;
        
        }
        public void GoBack()
        {
            if(s!=null)
            {
                s.Show();
            }
            this.Hide();
        }

        private void SignUpDeliveryBoy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DBBack_Click(object sender, EventArgs e)
        {
            this.GoBack();
        }

        private void DBSignIn_Click(object sender, EventArgs e)
        {
            //string s;
            if(check_Fields())
            {
                
                DataBase db = new DataBase();
                Logic Lo=new Logic();
                string hashpass=Lo.hash1(DBPass.Text).ToString();

                if(db.IsExisted_Login(DBEmail.Text)==true&&db.IsExisted_Request(DBEmail.Text)==true)
                {
                    if (db.Add_TMP_Database(DBFname.Text, DBLname.Text, DBPhone.Text, DBEmail.Text, hashpass, DBFloc.Text, DBSloc.Text))
                    {
                        MessageBox.Show("Your Request placed successfully!!!\nWait For Admin Approval");
                        WelcomePage w = new WelcomePage();
                        this.Hide();
                        w.Show();
                    }
                    else
                    {
                        MessageBox.Show("Try Again Letter\n");
                    }
                }
                else if(db.IsExisted_Login(this.DBEmail.Text)==false)
                {
                    MessageBox.Show("Already A Delivery Boy!!!");
                }
                else if(db.IsExisted_Request(this.DBEmail.Text)==false)
                {
                    MessageBox.Show("Already Requested!!! Wait for Admin Approval");
                }
                else
                {
                    MessageBox.Show("Error Occured!!\nTry Again Letter");
                }
            }
            else
            {
                MessageBox.Show("Fill Up The Form Properly!!!");
            }
        }

        private void DBFname_Leave(object sender, EventArgs e)
        {
            if (this.DBFname.Text == string.Empty)
            {
                this.FNameErr.Show();
            }
            else
            {
                this.FNameErr.Hide();
            }
            if (Logic.ReturnOK(this.DBFname.Text))
            {
                this.FnameValid.Hide();
            }
            else
            {
                this.FnameValid.Show();
            }
        }

        private void DBLname_Leave(object sender, EventArgs e)
        {
            if (this.DBLname.Text == string.Empty)
            {
                this.LnameErr.Show();
            }
            else
            {
                this.LnameErr.Hide();
            }
            if (Logic.ReturnOK(this.DBLname.Text))
            {
                this.LnameValid.Hide();
            }
            else
            {
                this.LnameValid.Show();
            }
        }

        private void DBPhone_Leave(object sender, EventArgs e)
        {
            if(Logic.Check_Number(DBPhone.Text)&&this.DBPhone.Text!=string.Empty)
            {
                this.PhValid.Hide();
            }
            else
            {
                this.PhValid.Show();
            }
        }

        private void DBEmail_Leave(object sender, EventArgs e)
        {
            if(Logic.IsEmailValid(DBEmail.Text)&&DBEmail.Text!=string.Empty)
            {
                this.EmailErr.Hide();
            }
            else
            {
                this.EmailErr.Show();
            }
        }

        private void DBPass_Leave(object sender, EventArgs e)
        {
            if (this.DBPass.Text == string.Empty)
            {
                this.PassErr.Show();
            }
            else
            {
                this.PassErr.Hide();
            }
            if (Logic.ReturnOK(this.DBPass.Text))
            {
                this.Passvalid.Hide();
            }
            else
            {
                this.Passvalid.Show();
            }
        }

        private void DBRpass_Leave(object sender, EventArgs e)
        {
            if(DBPass.Text!=DBRpass.Text)
            {
                this.Rpasserr.Show();
            }
            else
            {
                this.Rpasserr.Hide();
            }
        }

        private void DBFloc_Leave(object sender, EventArgs e)
        {
            if(DBFloc.Text==string.Empty)
            {
                this.fperrerr.Show();
            }
            else
            {
                this.fperrerr.Hide();
            }
        }

        private void DBSloc_Leave(object sender, EventArgs e)
        {
            if(DBSloc.Text==string.Empty)
            {
                this.spreferr.Show();
            }
            else
            {
                this.spreferr.Hide();
            }
        }
    }
}

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
    public partial class Details : Form
    {
        LogIn l;
        DeliverDashboard dash;
        int id;
        public Details(DeliverDashboard d,LogIn i,int s)
        {
            this.dash = d;
            this.l = i;
            this.id = s;
            InitializeComponent();
        }

        private void  Reload()
        {
            DataBase db = new DataBase();
            DataTable dt=db.Get_MyDetails(id);
            this.textBox1.Text = dt.Rows[0][0].ToString();
            this.textBox2.Text = dt.Rows[0][1].ToString();
            this.textBox3.Text = dt.Rows[0][2].ToString();
            this.pass.Text = dt.Rows[0][3].ToString();
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if(this.Cpass.Text!=this.textBox6.Text&&this.UP.Visible==true)
            {
                this.match.Show();
            }
            else
            {
                this.match.Hide();
            }
        }

        private void Cpass_Leave(object sender, EventArgs e)
        {
            Logic lo = new Logic();
            string passhash = lo.hash1(Cpass.Text).ToString();
            if (pass.Text != passhash && Cpass.Text != "")
            {
                this.UP.Show();
            }
            else
            {
                this.UP.Hide();
                this.match.Hide();
            }
        }

        private void Details_Shown(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void UP_Click(object sender, EventArgs e)
        {
           
            if(Cpass.Text!=textBox6.Text)
            {
                MessageBox.Show("Password Doesn't Match");
            }
            else
            {
                DataBase db = new DataBase();
                Logic lo = new Logic();
                string passhash = lo.hash1(Cpass.Text).ToString();
                if (db.Update_Password(passhash, id))
                {
                    MessageBox.Show("Updated Successfully!!!");
                    this.Hide();
                    dash.Show();
                    dash.RefreshPage();
                }
                else
                {
                    MessageBox.Show("Unsuccessfulll\n");
                }
            }
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
            dash.RefreshPage();
        }

        private void Details_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

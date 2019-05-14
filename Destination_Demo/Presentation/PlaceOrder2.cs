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
    public partial class PlaceOrder2 : Form
    {
        private PlaceOrder1 parent;
        private MemberDashBoard dash;
        private LogIn l;
        private int id;
        private string rcvaddress, rcvcity, pickupaddress, pickupcity;
        public PlaceOrder2(PlaceOrder1 p,MemberDashBoard m1,LogIn l1,int i,string pa,string pc,string ra,string rc )
        {
            this.parent = p;
            this.dash = m1;
            this.l = l1;
            this.id = i;
            this.pickupaddress = pa;
            this.pickupcity = pc;
            this.rcvaddress = ra;
            this.rcvcity = rc;
            InitializeComponent();
        }
        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }
        private bool Check_OK()
        {
            if (this.RCVFname.Text==""||this.RCVLname.Text==""||this.RcvPhone.Text==""||Logic.ReturnOK(RCVFname.Text)==false||
                Logic.ReturnOK(RCVLname.Text)==false||Logic.Check_Number(this.RcvPhone.Text)==false)
                return false;
            return true;
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void RCVFname_Leave(object sender, EventArgs e)
        {
            if (RCVFname.Text == "")
                this.FnameLabel.Visible = true;
            else
                this.FnameLabel.Visible = false;
            if (Logic.ReturnOK(RCVFname.Text))
            {
                this.FnameErr.Hide();
            }
            else
                this.FnameErr.Show();
        }

        private void RCVLname_Leave(object sender, EventArgs e)
        {
            if (RCVLname.Text == "")
                this.LNameLabel.Visible = true;
            else
                this.LNameLabel.Visible = false;
            if (Logic.ReturnOK(RCVLname.Text))
                this.Lnameerr.Hide();
            else
                this.Lnameerr.Show();
        }

        private void RcvPhone_Leave(object sender, EventArgs e)
        {
            if (RcvPhone.Text == "")
                this.PhoneLabel.Visible = true;
            else
                this.PhoneLabel.Visible = false;
            if (Logic.Check_Number(this.RcvPhone.Text))
                this.PhoneLabel.Hide();
            else
                this.PhoneLabel.Show();
        }

        private void PlaceOrder2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Order2Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void Order2Next_Click(object sender, EventArgs e)
        {
            if (Check_OK())
            {
                this.Hide();
                string tmp = this.RCVFname.Text;
                tmp += " ";
                tmp += this.RCVLname.Text;
                string phone = this.RcvPhone.Text;
                PlaceOrder3 p = new PlaceOrder3(this, dash, l,id,pickupaddress,pickupcity, rcvaddress, rcvcity, tmp,phone);
                p.Show();
            }
            else
            {
                MessageBox.Show("Fill Up the from properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class PlaceOrder1 : Form
    {
        private MemberDashBoard dash;
        private LogIn l;
        private int id;
        public PlaceOrder1(MemberDashBoard p,LogIn ll,int u)
        {
            this.dash = p;
            this.l = ll;
            this.id = u;
            InitializeComponent();
        }
        private bool check_OK()
        {
            if (this.Pickupaddress.Text==""||this.PickUpCity.Text==""||this.RCVAddress.Text==""||this.RCVCity.Text==""||Logic.IsAddressOk(this.Pickupaddress.Text)==false
                ||Logic.IsCity(this.PickUpCity.Text)==false||Logic.IsAddressOk(this.RCVAddress.Text)==false||Logic.IsCity(this.RCVCity.Text)==false)
                return false;
            else
                return true;
        }
        private void PlaceOrder1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void Order1Next_Click(object sender, EventArgs e)
        {
            if (check_OK())
            {
                this.Hide();
                string pickadd = this.Pickupaddress.Text;
                //pickadd += " City: ";
                //pickadd += this.PickUpCity.Text;
                string pickcity = this.PickUpCity.Text;
                string rcvaddress = this.RCVAddress.Text;
                //rcvaddress += " City: ";
                //rcvaddress += this.RCVCity.Text;
                string rcvcity = this.RCVCity.Text;
                PlaceOrder2 p = new PlaceOrder2(this, dash, l, id,pickadd,pickcity,rcvaddress,rcvcity);
                p.Show();
            }
            else
            {
                MessageBox.Show("Fill Up the from properly","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Pickupaddress_Leave(object sender, EventArgs e)
        {
            if (Pickupaddress.Text == "")
            {
                this.PAddressLabel.Visible = true;
            }
            else
                this.PAddressLabel.Visible = false;
            if(Logic.IsAddressOk(this.Pickupaddress.Text))
            {
                this.pickaddval.Hide();
            }
            else
            {
                this.pickaddval.Show();
            }
        }

        private void PickUpCity_Leave(object sender, EventArgs e)
        {
            if (PickUpCity.Text ==string.Empty)
                this.Pcitylabel.Visible = true;
            else
                this.Pcitylabel.Visible = false;
            if(Logic.IsCity(PickUpCity.Text))
            {
                this.pickcityvalid.Hide();
            }
            else
            {
                this.pickcityvalid.Show();
            }
        }

        private void RCVAddress_Leave(object sender, EventArgs e)
        {
            if (RCVAddress.Text == "")
                this.Rcbaddresslabel.Visible = true;
            else
                this.Rcbaddresslabel.Visible = false;
            if (Logic.IsAddressOk(this.RCVAddress.Text))
            {
                this.Rcvaddval.Hide();
            }
            else
                this.Rcvaddval.Show();
        }

        private void RCVCity_Leave(object sender, EventArgs e)
        {
            if (RCVCity.Text == "")
                this.RcityLabel.Visible = true;
            else
                this.RcityLabel.Visible = false;
            if (Logic.IsCity(this.RCVCity.Text))
            {
                this.rcvcityvalid.Hide();
            }
            else
                this.rcvcityvalid.Show();
        }
    }
}

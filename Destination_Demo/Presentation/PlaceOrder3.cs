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
    public partial class PlaceOrder3 : Form
    {
        private PlaceOrder2 parent;
        private LogIn l;
        private MemberDashBoard dash;
        private int id;
        private string rcvaddress,rcvcity, pickaddress,pickupcity, rname, rphone;
        public PlaceOrder3(PlaceOrder2 p,MemberDashBoard m,LogIn l1,int i,string r,string rc,string pa,string pc,string n,string c)
        {
            this.id = i;
            this.pickaddress = r;
            this.pickupcity = rc;
            this.rcvaddress = pa;
            this.rcvcity = pc;
            this.rname = n;
            this.rphone = c;
            this.parent = p;
            this.dash = m;
            this.l = l1;

            InitializeComponent();
        }
        private bool check_OK()
        {
            return PaymentType.Text == "Cash On PickUp" || PaymentType.Text == "Cash From Receiver";
        }

        private void PlaceOrder3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void PaymentType_Leave(object sender, EventArgs e)
        {
            if(check_OK())
            {
                this.inavlid.Hide();
            }
            else
            {
                this.inavlid.Show();
            }
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
            
        }

        private void Order2Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void Order2Next_Click(object sender, EventArgs e)
        {
            if (check_OK())
            {
                string pt = this.PaymentType.Text;
                string add = this.Addinfo.Text;
                string uid = "U";
                uid += id.ToString();
                string fname, lname, phone;
                DataBase db = new DataBase();
                db.Get_User_Order(uid,out fname,out lname,out phone);
                string sendername = fname;
                sendername += " " + lname;
                string pcity = this.pickaddress;
                pcity += " City: " + this.pickupcity;
                string rcity = this.rcvaddress;
                rcity += " City: " + this.rcvcity;
                db.User_Add_Order(uid, sendername, pcity, phone, rname, rcity, rphone, pt, add);
                OrderHistory n = new OrderHistory(dash, l, uid);
                n.Show();
                this.Hide();

                //MessageBox.Show(rname, rphone);
                //ConfirmOrder p = new ConfirmOrder(this, dash, l,id,pickaddress,pickupcity,rcvaddress,rcvcity,rname,rphone,pt,add);
            }
            else
            {
                MessageBox.Show("Fill Up the form properly","Error");
            }
        }
    }
}

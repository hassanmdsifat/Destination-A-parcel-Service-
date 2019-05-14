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
    public partial class DeliverDashboard : Form
    {
        LogIn l;
        int id;
        public DeliverDashboard(LogIn i,int it)
        {
            this.l = i;
            this.id = it;
            InitializeComponent();
        }

        private void DeliverDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void NewRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestForm n = new RequestForm(this,l,id);
            n.Show();
        }

        private void OrderHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHistoryForm n = new OrderHistoryForm(this,l,id);
            n.Show();
        }
        public void RefreshPage()
        {
            string s = "D";
            s += id.ToString();
            DataBase db = new DataBase();
            int cnt=db.Get_CountPending_Order(s);
            //MessageBox.Show(cnt.ToString());
            if(cnt==1)
            {
                this.NewRequest.BackColor = Color.Red;
            }
            else
            {
                this.NewRequest.BackColor = Color.LimeGreen;
            }
        }

        private void DeliverDashboard_Shown(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        private void Mydetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Details n = new Details(this, l, id);
            n.Show();
        }
    }
}

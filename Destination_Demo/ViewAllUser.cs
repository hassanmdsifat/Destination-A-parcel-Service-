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
    public partial class ViewAllUser : Form
    {
        LogIn l;
        AdminDashBoard dash;
        public ViewAllUser(AdminDashBoard d,LogIn i)
        {
            this.dash = d;
            this.l = i;
            InitializeComponent();
        }

        private void ViewAllUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewAllUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void ReloadData()
        {
            DataBase db = new DataBase();
            DataTable dt = db.Get_UserList();
            this.UserGrid.DataSource = dt;
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ViewAllUser_Shown(object sender, EventArgs e)
        {
            this.ReloadData();
        }

        private void NotiDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }

        private void NotiLoogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }
    }
}

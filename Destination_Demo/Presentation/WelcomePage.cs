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

namespace Destination_Demo
{
    public partial class WelcomePage : Form
    {
        //const string constr = "Data Source=DESKTOP-CAOLCCP;Initial Catalog=DESTINATION;Integrated Security=True";
        ///SqlConnection sql = new SqlConnection(constr);
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //sql.Open();
            this.Hide();
            LogIn l1 = new LogIn(this);
            l1.Show();   
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp(this).Show();
        }
    }
}

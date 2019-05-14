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
    public partial class AdminNewOrder : Form
    {
        AdminDashBoard dash;
        LogIn l;
        DataTable dt;
        int OrderID;
        string RCVLOC;
        string PLOC;
        bool rowSelected = false;
        public AdminNewOrder(AdminDashBoard d,LogIn i)
        {
            this.dash = d;
            this.l = i;
            InitializeComponent();
        }

        private void AdminNewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminNewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
        }

        private void OrderDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
            dash.ReloadData();
        }

        private void NewOrderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0&&e.RowIndex<NewOrderGrid.RowCount-1){ 
                DataBase db = new DataBase();
                DataGridViewRow dt = NewOrderGrid.Rows[e.RowIndex];
                OrderID = (int)dt.Cells[0].Value;
                this.PLOC = dt.Cells[3].Value.ToString();
                DataTable Rcv=db.get_Receiver_Details(OrderID);
                this.RCVname.Text = Rcv.Rows[0][0].ToString();
                this.RCVPhone.Text = Rcv.Rows[0][2].ToString();
                this.Addressbox.Text = Rcv.Rows[0][1].ToString();
                this.RCVLOC = this.Addressbox.Text;
                this.OrderType.Text = Rcv.Rows[0][3].ToString();
                this.AddInfo.Text = Rcv.Rows[0][4].ToString();
                this.AssignDB.Visible = true;
                this.CancelOrder.Visible = true;
                rowSelected = true;
           }
           else
            {
                ClearFields();
            }
        }

        public void ClearFields()
        {
            this.RCVname.Text = "";
            this.RCVPhone.Text = "";
            this.Addressbox.Text = "";
            this.OrderType.Text = "";
            this.AddInfo.Text = "";
            this.AssignDB.Visible = false;
            this.CancelOrder.Visible = false;
            rowSelected = false;
        }

        private void AssignDB_Click(object sender, EventArgs e)
        {
            Assign_Delivery_Boy n = new Assign_Delivery_Boy(this,OrderID,dash,l,PLOC,RCVLOC,NewOrderGrid);
            n.Show();
            this.Hide();
        }

        private void AdminNewOrder_Shown(object sender, EventArgs e)
        {
            this.ReloadData();
        }

        public void ReloadData()
        {
            DataBase db = new DataBase();
            dt = db.get_Sender_Details();
            this.NewOrderGrid.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                AssignDB.Hide();
                this.CancelOrder.Hide();
            }
            else if (rowSelected)
            {
                AssignDB.Show();
                this.CancelOrder.Show();
            }
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if(db.Cancel_Order(this.OrderID))
            {
                this.ReloadData();
                this.ClearFields();
            }
            else
                this.ReloadData();
        }
    }
}

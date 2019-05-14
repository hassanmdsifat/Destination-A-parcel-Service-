using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DatabaseConnection
{
   
    public partial class DataBase
    {
        const string constr = @"Data Source=SIFAT\SIFAT;Initial Catalog=DestinationDatabase;User ID=sa;Password=Sifat";
        public void AddUser(string fname,string lname,string phone,string email,string pass)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if(sql.State==System.Data.ConnectionState.Open)
            {
                string query="insert into Login_Table values('"+"U"+"','"+email+"','"+pass+"','"+"Y"+"')";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                string LogInId = "select LoginID from Login_Table where Email='" + email + "'and Password='"+pass+"'";
                SqlDataAdapter sda = new SqlDataAdapter(LogInId, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int id = (int)dt.Rows[0][0];
                string s = "U";
                s += id.ToString();
                //query = "insert into User_Table values('" + s + "','" +fname+ "','" + lname + "','"+phone+"','"+email+'",'"+id)";
                query = $"INSERT INTO User_Table VALUES('{s}','{fname}', '{lname}', '{phone}', '{email}','{pass}', '{id}','{"Y"}')";
                cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();


            }
            
        }
        public bool Email_Verification(string email)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from Login_Table where Email='{email}' and Type='{"U"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public string Check_Who(string uname,string pass, out int id,out string status)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            id = -1;
            status = null;
            if(sql.State==ConnectionState.Open)
            {
                string query = $"select Type,LoginID,LogStatus from Login_Table where Email='{uname}' and Password='{pass}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    id = (int)dt.Rows[0][1];
                    status = dt.Rows[0][2].ToString();
                    return dt.Rows[0][0].ToString();
                    
                }
                //id = -1;
                else
                    return null;
            }
            return null;
        }
        public void Get_User_Order(string s,out string f,out string st,out string p)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if(sql.State==ConnectionState.Open)
            {
                string query = $"select FirstName,LastName,Phone from User_Table where UserID='{s}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                f = dt.Rows[0][0].ToString();
                st = dt.Rows[0][1].ToString();
                p = dt.Rows[0][2].ToString();
            }
            else
            {
                f = null;
                st = null;
                p = null;
            }

        }
        public void User_Add_Order(string id,string sname,string loc,string phone,string rname,string radd,string rphone,string ptype,string add)
        {
            string os = "P";
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if(sql.State==ConnectionState.Open)
            {
                string query = $"insert into Order_Table(SenderID,SenderName,SenderLocation,SenderPhone,RCVName,RCVLocation,RCVPhone,PaymentType,AddInfo,OrderStatus) values ('{id}','{sname}','{loc}','{phone}','{rname}','{radd}','{rphone}','{ptype}','{add}','{"PENDING"}')";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
            }

        }
        public DataTable Get_User_OrderHistory(string id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select OrderID,RCVName,RCVLocation,RCVPhone,OrderStatus from Order_Table where SenderID='{id}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public void GetOrder_Type(int OrderID,out string pt,out string add)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            pt = null;
            add = null;
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select PaymentType,AddInfo from Order_Table where OrderID='{OrderID}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                pt = dt.Rows[0][0].ToString();
                add = dt.Rows[0][1].ToString();
            }

        }
        public string Get_DeliveryBoyId(int orderID)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select DBID from Order_Table where OrderID='{orderID}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            else
                return null;

        }
        public void Get_DelieryBoyDetails(string db_id,out string name,out string phone)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            name = null;
            phone = null;
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select FirstName,LastName,Phone from DeliveryBoy_Table where DBID='{db_id}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string tmp = dt.Rows[0][0].ToString();
                tmp += " " + dt.Rows[0][1].ToString();
                name = tmp;
                phone = dt.Rows[0][2].ToString();
            }
        }
     
    }
}

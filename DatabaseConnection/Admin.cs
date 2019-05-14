using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public partial class DataBase
    {
        public DataTable get_newOrder()
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from Order_Table where OrderStatus='{"PENDING"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public DataTable get_Sender_Details()
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select OrderID,SenderName,SenderPhone,SenderLocation from Order_Table where OrderStatus='{"PENDING"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public DataTable get_Receiver_Details(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select RCVName,RCVLocation,RCVPhone,PaymentType,AddInfo from Order_Table where OrderID='{id}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        } 
        public DataTable Get_DeliveryBoy_Details()
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select DBID,FirstName,LastName,Phone,Flocation,Slocation from DeliveryBoy_Table where LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public DataTable Get_DeliveryBOY_City(string s)
        {
            //MessageBox.Show("s");
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select DBID,FirstName,LastName,Phone,Flocation,Slocation from DeliveryBoy_Table where (Flocation like '%{s}%' or Slocation like '%{s}%') and LogStatus='{"Y"}' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public bool Update_Order(int id,string dbid)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"update Order_Table set DBID='{dbid}',OrderStatus='{"ACCEPT"}' where OrderID='{id}'";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
                return false;
        }
        public bool Cancel_Order(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"update Order_Table set OrderStatus='{"CANCEL"}' where OrderID='{id}'";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
                return false;
        }
        public DataTable Get_NewDBRequest()
        {
            //MessageBox.Show("s");
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from TMP_DBTABLE1";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public void delete_TMP_Request(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"delete from TMP_DBTABLE1 where ID='{id}'";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                
            }
        }
        public DataTable Select_TmpRequest(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from TMP_DBTABLE1 where ID='{id}'";
                SqlDataAdapter sda= new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public bool AddDeliveryBoy(string fname, string lname, string phone, string email, string pass,string Floc,string SLoc)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == System.Data.ConnectionState.Open)
            {
                string query = "insert into Login_Table values('" + "D" + "','" + email + "','" + pass + "','"+"Y"+"')";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                string LogInId = "select LoginID from Login_Table where Email='" + email + "'and Password='" + pass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(LogInId, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int id = (int)dt.Rows[0][0];
                string s = "D";
                s += id.ToString();
                //query = "insert into User_Table values('" + s + "','" +fname+ "','" + lname + "','"+phone+"','"+email+'",'"+id)";
                query = $"INSERT INTO DeliveryBoy_Table VALUES('{s}','{fname}','{lname}','{phone}', '{email}','{pass}','{Floc}','{SLoc}','{id}','{"Y"}')";
                cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;

        }
        public DataTable Get_All_DeliveryBoy()
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from DeliveryBoy_Table where LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public DataTable Get2_DeliveryBoy_City(string s)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from DeliveryBoy_Table where (Flocation like '%{s}%' or Slocation like '%{s}%') and LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public DataTable Get_DeliveryBoy_Name(string s)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from DeliveryBoy_Table where (FirstName like '%{s}%' or LastName like '%{s}%') and LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public DataTable Get_DeliveryBoy_ID(string s)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from DeliveryBoy_Table where DBID like '%{s}%' and LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public bool Delete_DeliveryBoy(string s,int l)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                //string query = $"delete from DeliveryBoy_Table where DBID='{s}'";
                string up = $"update Login_Table set LogStatus='{"N"}' where LoginID='{l}'";
                SqlCommand cmd = new SqlCommand(up,sql);
                cmd.ExecuteNonQuery();
                up = $"update DeliveryBoy_Table set LogStatus='{"N"}' where LoginID='{l}'";
                cmd = new SqlCommand(up, sql);
                cmd.ExecuteNonQuery();
                return true;

            }
            else
                return false;
        }
        public DataTable get_AllOrder()
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from Order_Table";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public DataTable Get_UserList()
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from User_Table where LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
    }
  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection
{
    partial class DataBase
    {
       public bool Add_TMP_Database(string fname,string sname,string ph,string em,string pass,string floc,string sloc)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State ==System.Data.ConnectionState.Open)
            {
                string query = $"Insert into TMP_DBTABLE1 values('{fname}','{sname}','{ph}','{em}','{pass}','{floc}','{sloc}')";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
                return false;
        }
        public int Get_CountPending_Order(string s)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from Order_Table where DBID='{s}' and OrderStatus='{"ACCEPT"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    return 1;
                }
                else
                    return 0;
            }
            return 0;
        }
        public DataTable Get_Order_Details(string s)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select OrderID,SenderName,SenderLocation,SenderPhone,PaymentType from Order_Table where DBID='{s}' and OrderStatus='{"ACCEPT"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public DataTable Get_OrderR_Details(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select RCVName,RCVLocation,RCVPhone,PaymentType from Order_Table where OrderID='{id}' and OrderStatus='{"ACCEPT"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public bool Done_Order(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                //string query = $"delete from DeliveryBoy_Table where DBID='{s}'";
                string up = $"update Order_Table set OrderStatus='{"DONE"}' where OrderID='{id}'";
                SqlCommand cmd = new SqlCommand(up, sql);
                cmd.ExecuteNonQuery();
                return true;

            }
            else
                return false;
        }
        public DataTable Get_All_Order(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string s = "D";
                s += id.ToString();
                string query = $"select SenderName,SenderLocation,RCVName,RCVLocation from Order_Table where DBID='{s}' and OrderStatus='{"DONE"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public DataTable Get_MyDetails(int id)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            string s = "D";
            s += id.ToString();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select FirstName,LastName,Phone,Password from DeliveryBoy_Table where DBID='{s}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            return null;
        }
        public bool Update_Password(string s,int id)
        {
             SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                //string query = $"delete from DeliveryBoy_Table where DBID='{s}'";
                string up = $"update Login_Table set Password='{s}' where LoginID='{id}'";
                SqlCommand cmd = new SqlCommand(up, sql);
                cmd.ExecuteNonQuery();
                string nn = "D";
                nn += id.ToString();
                up = $"update DeliveryBoy_Table set Password='{s}' where DBID='{nn}'";
                cmd = new SqlCommand(up, sql);
                cmd.ExecuteNonQuery();
                return true;

            }
            else
                return false;
        }
        public bool IsExisted_Login(string email)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from Login_Table where Email='{email}' and LogStatus='{"Y"}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public bool IsExisted_Request(string email)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            if (sql.State == ConnectionState.Open)
            {
                string query = $"select *from TMP_DBTABLE1 where Email='{email}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destination_Demo
{
   public class User
    {
        private string Type,Id,Fname, Lname,PhoneNumber,email;
       private  List<Order> order;
        public User(string t,string f,string l,string p,string e)
        {
            this.Type = t;
            this.Fname = f;
            this.Lname = l;
            this.PhoneNumber = p;
            this.email = e;
        }
        public string GetName
        {
            get
            {
                string tmp = this.Fname;
                tmp += " ";
                tmp += this.Lname;
                return tmp;
            }
        }
        public string GetNumber
        {
            get
            {
                return this.PhoneNumber;
            }
        }
        public string GetEmail
        {
            get
            {
                return this.email;
            }
        }
        public string ID
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
    }
}

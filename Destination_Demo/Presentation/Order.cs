using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destination_Demo
{
    public class Order
    {
        string sName, sAddress,scity, sphone, rcvName, rcvAddress,rcvcity, rcvPhone, pType;
        string info;
        public Order(string sn,string sp)
        {
            sName = sn;
            sphone = sp;
        }
        public string SenName
        {
            set
            {
                this.sName = value;
            }
            get
            {
                return this.sName;
            }
        }
        public string  SenAdd
        {
            set
            {
                this.sAddress = value;
            }
            get
            {
                return this.sAddress;
            }
        }
        public string SenCity
        {
            set
            {
                this.scity = value;
            }
            get
            {
                return this.scity;
            }
        }
        public string SenPhone
        {
            set
            {
                this.sphone = value;
            }
            get
            {
                return this.sphone;
            }
        }
         public string RCVName
        {
            set
            {
                this.rcvName = value;
            }
            get
            {
                return this.rcvName;
            }
         }
        public string RCVaddress
        {
            set
            {
                this.rcvAddress = value;
            }
            get
            {
                return this.rcvAddress;
            }
        }
        public string RCVCITY
        {
            set
            {
                this.rcvcity = value;
            }
            get
            {
                return this.rcvcity;
            }
        }
        public string RCVPhone
        {
            set
            {
                this.rcvPhone = value;
            }
            get
            {
                return this.rcvPhone;
            }
        }
        public string OTYPE
        {
            set
            {
                this.pType = value;
            }
            get
            {
                return this.pType;
            }
        }
        public string INFO
        {
            set
            {
                this.info = value;
            }
            get
            {
                return this.info;
            }
        }
    }
}

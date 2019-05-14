using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class Logic
    {
        private long Hash1 = 1000000007;
        public static bool Check_Number(string s)
        {
            if(s.Length==11)
            {
                for(int i=0;i<s.Length;i++)
                {
                    if(s[i]>='0'&&s[i]<='9')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public long hash1(string s)
        {
            long val = 0, power = 1,ba = 133;
            long len = s.Length;
            for (int i = (int)len - 1; i >= 0; i--)
            {
                val = val + ((s[i] - 'a') * power) % Hash1;
                val %= Hash1;
                power = (power * ba) % Hash1;
            }
            return val;
        }
        public static bool ReturnOK(string s)
        {
            if (s.Length <= 40)
                return true;
            else
                return false;
        }

        public static bool IsEmailValid(string s)
        {
            return Regex.IsMatch(s, @".+@.+\..+", RegexOptions.IgnoreCase);
        }
        public static bool IsAddressOk(string s)
        {
            if(s.Length<=80)
            {
                return true;
            }
            return false;
        }
        public static bool IsCity(string s)
        {
            if (s.Length<=15)
                return true;
            else
                return false;
        }
    }
}

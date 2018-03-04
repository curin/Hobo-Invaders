using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invaders
{
    public class WriteableString
    {
        public string addtostring(string st, string a)
        {
            return st += a;
        }
        public string removeall()
        {
            return  "";
        }
        public string removelast(string st)
        {
           return st.Remove(st.Length - 1);
        }
    }
}

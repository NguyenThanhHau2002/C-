using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class HuyChuoi {
        string s;
        int n, p;
         
        public HuyChuoi(string s, int n, int p)
        {
            this.s = s;
            this.n = n;
            this.p = p;
        }

        public static string Unchain(string s, int n, int p)
    {
        if (p < 0 || n < 0 || p >= s.Length)
        {
            return s;
        }
        if (n > s.Length - p)
        {
            return s.Substring(0, p);
        }
        return s.Substring(0, p) + s.Substring(p + n);
    }
} 

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTTHKC_Bai1
{
    public class Chuoi
    {
        public int String(string s, string s1)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s1))
            {
                return -1;
            }

            int index = s.IndexOf(s1, StringComparison.Ordinal);
            if (index == -1)
            {
                Console.WriteLine($"Không tìm thấy {s1} trong {s}");
            }

            return index;
        }
    }
}

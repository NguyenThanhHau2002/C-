using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ChuyenDoi
    {
        public static string Convert(int val, int coso)
        {
            string buf = "";
            int d;
            while (val > 0)
            {
                d = val % coso;
                buf = ToString(d) + buf;
                val = val / coso;
            }
            return buf;
        }
        public static string ToString(int d)
        {
            string buf = "";
            switch (d)
            {
                case 0: buf = "0"; break;
                case 1: buf = "1"; break;
                case 2: buf = "2"; break;
                case 3: buf = "3"; break;
                case 4: buf = "4"; break;
                case 5: buf = "5"; break;
                case 6: buf = "6"; break;
                case 7: buf = "7"; break;
                case 8: buf = "8"; break;
                case 9: buf = "9"; break;
                case 10: buf = "A"; break;
                case 11: buf = "B"; break;
                case 12: buf = "C"; break;
                case 13: buf = "D"; break;
                case 14: buf = "E"; break;
                case 15: buf = "F"; break;
            }
            return buf;
        }

    }
}

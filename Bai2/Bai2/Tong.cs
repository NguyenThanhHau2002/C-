using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Tong
    {
      
        public static  int TinhTong(int n) {
            int i = 1;
            int tong = 0;
            while (i < n) {
                tong += i;
                i = i + 1;
            }
            return tong;
        }
        

    }
}

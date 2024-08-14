using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Chuoi
    {
        String[] ssList = new string[100];
        int ssCount = 0;
       public  int SIndex(String s)
        {
            int i;
            for (i = 0; i < ssCount; i++)
                if (s == ssList[i]) return i;
            ssList[ssCount] = s;
            return ssCount++;
        }
    }
}

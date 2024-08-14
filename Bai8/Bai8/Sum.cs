using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Sum
    {
        public static void SumCalculator(long s0, out long s, out long k)
        {
            s = 0;
            k = 0;
            for (long i = 1; i <= s0; i++)
            {
                s += i;
                k++;
            }
        }
    }
}

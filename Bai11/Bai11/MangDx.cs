using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai11
{
    public class MangDX
    {    int[] a;
         int n;

        public MangDX(int[] a, int n)
        {
            this.a = a;
            this.n = n;
        }

        public static bool IsSymmetry(int[] a, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

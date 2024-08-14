using System;

namespace Bai10
{
    public class Largest
    {
         int[] a;

        public Largest(int[] a)
        {
            this.a = a;
        }

        public static int GiaTriLon(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return int.MaxValue;
            }
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}

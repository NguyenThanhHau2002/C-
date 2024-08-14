using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class HexToDecConverter
    {
        public string Convert(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
                return "Invalid input";

            try
            {
                long GiaTriTP = System.Convert.ToInt64(hex, 16);
                return GiaTriTP.ToString();
            }
            catch
            {
                return "Invalid input";
            }
        }
    }
}

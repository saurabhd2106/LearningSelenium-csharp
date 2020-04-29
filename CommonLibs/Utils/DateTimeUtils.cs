using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs.Utils
{
    public class DateTimeUtils
    {
        public static string GetCurrentDateAndTime()
        {
            return DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’-’mm’-’ss");

        }
    }
}

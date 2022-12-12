using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Pincode
{
    internal class RegexPattern
    {
        public static void Pattern(long pattern)
        {
            Regex code = new Regex("^[1-9]{1}[0-9]{5}$");
            bool matches = code.IsMatch(Convert.ToString(pattern));

            if (matches == true)
            {
                Console.WriteLine("Pncode is valid");
            }
            else
            {
                Console.WriteLine("Please Enter valid Pincode");
            }
        }
    }
}

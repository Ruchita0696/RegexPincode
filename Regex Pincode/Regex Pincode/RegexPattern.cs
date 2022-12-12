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
        public static void Pattern(string pattern)
        {
            Regex code = new Regex("^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$");
            bool matches = code.IsMatch(pattern);

            if (matches == true)
            {
                Console.WriteLine("Pincode is valid");
            }
            else
            {
                Console.WriteLine("Please Enter valid Pincode");
            }
        }
    }
}

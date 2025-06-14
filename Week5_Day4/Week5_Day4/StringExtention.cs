using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day4
{
    static public class StringExtention
    {
        static public string Mirror2(this string str)
        {
            var value = str.ToCharArray();
            Array.Reverse(value);
            return new string(value);

        }
    }
}

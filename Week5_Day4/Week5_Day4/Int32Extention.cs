using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day4
{
    static public class Int32Extention
    {
        static public int Mirror1( this int num)
        {
            var value = num.ToString().ToCharArray();
            Array.Reverse(value);
            return int.Parse(new string(value));
        }
    }
}

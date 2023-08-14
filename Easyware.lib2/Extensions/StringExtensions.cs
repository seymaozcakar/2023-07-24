using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyware.Lib2.Extensions
{
    public static class StringExtensions //ext methodlar static classlarda olur.
    {
        public static int WordCount(this string str) 
        { 
         return str.Split(" ",StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int WordCount(this string str, string seperators)
        {
            return str.Split(seperators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static bool IsNumber(this string str)
        {
            return int.TryParse(str, out var result);
        }

    }
}

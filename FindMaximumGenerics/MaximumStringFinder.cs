using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    internal class MaximumStringFinder
    {
        public static string FindMaximumString(string str1, string str2, string str3)
        {
            string maxString = str1;

            if (string.Compare(str2, maxString) > 0)
            {
                maxString = str2;
            }

            if (string.Compare(str3, maxString) > 0)
            {
                maxString = str3;
            }

            return maxString;
        }
    }
}

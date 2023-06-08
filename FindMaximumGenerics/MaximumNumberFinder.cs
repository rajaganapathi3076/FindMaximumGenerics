using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    internal class MaximumNumberFinder
    {
        public static int FindMaximumNumber(int num1, int num2, int num3)
        {
            int maxNumber = num1;

            if (num2.CompareTo(maxNumber) > 0)
            {
                maxNumber = num2;
            }

            if (num3.CompareTo(maxNumber) > 0)
            {
                maxNumber = num3;
            }

            return maxNumber;
        }
    }
}

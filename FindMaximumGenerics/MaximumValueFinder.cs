using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    internal class MaximumValueFinder
    {
        public static T FindMaximumValue<T>(T value1, T value2, T value3) where T : IComparable<T>
        {
            T maxValue = value1;

            if (value2.CompareTo(maxValue) > 0)
            {
                maxValue = value2;
            }

            if (value3.CompareTo(maxValue) > 0)
            {
                maxValue = value3;
            }

            return maxValue;
        }
    }
}

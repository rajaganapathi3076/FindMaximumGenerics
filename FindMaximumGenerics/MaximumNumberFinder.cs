using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    public class MaximumValueFinder<T> where T : IComparable<T>
    {
        private T value1;
        private T value2;
        private T value3;

        public MaximumValueFinder(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public T FindMaximum()
        {
            return MaximumValueFinder.FindMaximumValue(value1, value2, value3);
        }

        private static T FindMaximumValue(T value1, T value2, T value3)
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

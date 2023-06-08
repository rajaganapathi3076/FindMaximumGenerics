using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    public class MaximumValueFinder<T> where T : IComparable<T>
    {
        private List<T> values;

        public MaximumValueFinder(params T[] values)
        {
            this.values = new List<T>(values);
        }

        public T FindMaximum()
        {
            if (values.Count == 0)
            {
                throw new InvalidOperationException("No values provided.");
            }

            values.Sort();

            return values[values.Count - 1];
        }

    }
    
}

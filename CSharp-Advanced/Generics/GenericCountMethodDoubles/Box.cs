using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T: IComparable
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public int GetComparedElement (T element)
        {
            int count = 0;

            foreach (T item in this.Values)
            {
                if (element.CompareTo(item) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

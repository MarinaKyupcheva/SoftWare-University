using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        public List<T> FirstElements { get; set; } = new List<T>();

        public Box(List<T> firstElements)
        {
            this.FirstElements = firstElements;

        }

        public int GetCountOfCompareElements(T secondElement)
        {
            int count =0;

            foreach (T item in FirstElements)
            {
                if(secondElement.CompareTo(item) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

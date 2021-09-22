using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public void Swap(int firstindex, int secondIndex)
        {
            T tempIndex = this.Values[firstindex];
            this.Values[firstindex] = this.Values[secondIndex];
            this.Values[secondIndex] = tempIndex;
        
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var value in this.Values)
            {
                stringBuilder.AppendLine($"{value.GetType()}: {value}");
            }
           

            return stringBuilder.ToString().Trim();
        }
    }
}

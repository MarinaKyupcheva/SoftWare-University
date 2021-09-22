using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.count = 0;
            this.items = new int[InitialCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;

            }
        }
        public void Push(int element)
        {
            if(this.items.Length == this.count)
            {
                var nextItems = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    nextItems[i] = this.items[i];
                }
                this.items = nextItems;
             
            }
            this.items[this.count] = element;
            count++;
        }

        public int Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            this.items[this.Count - 1] = default;
            this.count--;
            return last;
        }
        public int Peek()
        {
            if(this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            return last;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}

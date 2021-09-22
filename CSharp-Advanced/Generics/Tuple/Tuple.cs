using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TItem1, TItem2>
    {
        public TItem1 FirstItem { get; set; }
        public TItem2 SecondItem { get; set; }

        public Tuple(TItem1 firstItem, TItem2 secondItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
}

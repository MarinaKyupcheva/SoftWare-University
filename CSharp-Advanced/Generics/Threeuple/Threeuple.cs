using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<TItem1, TItem2, TItem3>
    {
        public TItem1 FirstItem { get; set; }
        public TItem2 SecondItem { get; set; }
        public TItem3 ThirdItem { get; set; }

        public Threeuple(TItem1 firstItem, TItem2 secondItem, TItem3 thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}";   
        }
    }
}

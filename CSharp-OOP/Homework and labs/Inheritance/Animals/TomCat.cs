using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class TomCat : Cat
    {
        public TomCat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}

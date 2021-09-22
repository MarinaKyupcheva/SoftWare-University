using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();
            
            foreach (var item in text) 
            {
                if (char.IsDigit(item))
                {
                    digits.Append(item);
                   
                }

                else if (char.IsLetter(item))
                {
                    letters.Append(item);
                   
                }

                else
                {
                    characters.Append(item);
                    
                }
            }
            Console.WriteLine($"{digits}\n{letters}\n{characters}");
        }
    }
}

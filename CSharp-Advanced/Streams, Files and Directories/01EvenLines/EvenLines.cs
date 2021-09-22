using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Streams__Files_and_Directories
{
    class EvenLines
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
                int counter = 0;

                while(line != null)
                {
                    if (counter % 2 == 0)
                    {
                        Regex pattern = new Regex("[-,.!?]");
                        line = pattern.Replace(line, "@");
                        string[] array = line.Split(" ");
                        Console.WriteLine(string.Join(" ", array.Reverse()));
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

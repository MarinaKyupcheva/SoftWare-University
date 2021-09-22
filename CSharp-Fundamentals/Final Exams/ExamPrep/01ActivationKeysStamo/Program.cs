using System;
using System.Text;

namespace _01ActivationKeysStamo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cmd = Console.ReadLine();
            while (cmd != "Generate")
            {
                string[] cmdArg = cmd.Split(">>>");
                string command = cmdArg[0];
                

                if (command == "Contains")
                {
                    string substring = cmdArg[1];
                    if (input.Contains(substring))
                    {
                        
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    
                    int startIndex = int.Parse(cmdArg[2]);
                    int endIndex = int.Parse(cmdArg[3]);

                    string firstPart = input.Substring(0, startIndex);
                    string secontPart = input.Substring(startIndex, endIndex - startIndex);
                    string thirdPart = input.Substring(endIndex);
                    if(cmdArg[1] == "Upper")
                    {
                        secontPart = secontPart.ToUpper();
                    }
                    else
                    {
                        secontPart = secontPart.ToLower();
                    }
                    input = firstPart + secontPart + thirdPart;
                    Console.WriteLine(input);

                }
                else if(command == "Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }


                cmd = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}

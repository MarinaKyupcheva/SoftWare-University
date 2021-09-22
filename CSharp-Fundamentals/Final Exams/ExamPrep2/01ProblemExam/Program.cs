using System;

namespace _01ProblemExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];

                if(command == "Change")
                {
                    string charr = cmdArg[1];
                    string replacement = cmdArg[2];

                    if (message.Contains(charr))
                    {
                        message = message.Replace(charr, replacement);

                    }
                    Console.WriteLine(message);
                }
                else if(command == "Includes")
                {
                    string stringg = cmdArg[1];

                    if (message.Contains(stringg))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
               else if(command == "End")
                {
                    string stringg = cmdArg[1];

                    bool isTrue = message.EndsWith(stringg);

                    if (isTrue)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    

                    
                }
                else if(command == "Uppercase")
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
               else if(command == "FindIndex")
                {
                    string charr = cmdArg[1];
                    int firstIndex = message.IndexOf(charr);
                    Console.WriteLine(firstIndex);


                }
                else if(command == "Cut")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);

                    message = message.Substring(startIndex, lenght);
                    Console.WriteLine(message);
                }
               
                     
                

                input = Console.ReadLine();
            }

        }
    }
}

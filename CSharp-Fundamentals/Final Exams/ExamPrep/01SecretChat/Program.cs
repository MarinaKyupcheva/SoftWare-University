using System;
using System.Linq;
using System.Text;

namespace _01SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string [] cmdArg = input.Split(":|:");
                string command = cmdArg[0];

                if(command == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if(command == "Reverse")
                {
                    string substring = cmdArg[1];

                    if (message.Contains(substring))
                    {
                        string reversed = string.Empty;
                       int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversed += substring[i];
                        }
                        message += reversed;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(command == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];

                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                        Console.WriteLine(message);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

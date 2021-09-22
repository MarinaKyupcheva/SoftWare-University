using System;

namespace _01TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input!= "Decode")
            {
                string[] cmdArg = input.Split("|");
                string command = cmdArg[0];
                if(command == "Move")
                {
                    int numberOfLettrs = int.Parse(cmdArg[1]);

                    string firstStrings = message.Substring(0, numberOfLettrs);
                    string secondString = message.Substring(numberOfLettrs, message.Length - numberOfLettrs);
                    
                    message = secondString +  firstStrings;
                    
                    
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    string value = cmdArg[2];

                   message = message.Insert(index, value);
                   
                }
                else if(command == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replareplacement = cmdArg[2];

                    message = message.Replace(substring, replareplacement);
                   

                }



                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

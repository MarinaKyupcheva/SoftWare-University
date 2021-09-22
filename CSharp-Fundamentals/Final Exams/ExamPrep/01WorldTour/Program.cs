using System;

namespace _01WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input = Console.ReadLine();

            while(input != "Travel")
            {
                string[] cmdArg = input.Split(":");
                string command = cmdArg[0];

                if(command == "Add Stop")
                {
                    int index = int.Parse(cmdArg[1]);
                    string stringg = cmdArg[2];

                    if(index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, stringg);
                        Console.WriteLine(stops);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    if (startIndex >= 0 && endIndex >= 0 && endIndex <= stops.Length - 1)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(stops);

                }
                else if(command == "Switch")
                {
                    string oldString = cmdArg[1];
                    string newString = cmdArg[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                        Console.WriteLine(stops);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}

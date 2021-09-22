using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split(" ");
            string[] urls = Console.ReadLine().Split(" ");

            Smartphone smartphone = new Smartphone();
            Stationaryphone stationaryphone = new Stationaryphone();

            foreach (var number in phones)
            {
                try
                {
                    string result = number.Length == 10
                   ? smartphone.Call(number)
                   : stationaryphone.Call(number);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex) 
                {

                    Console.WriteLine(ex.Message);
                }
               
            }

            foreach (var url in urls)
            {
                try
                {
                    string result = smartphone.Browse(url);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

using System;

namespace _1ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWithoutTax = double.Parse(Console.ReadLine());
            string typeOfCustomer = Console.ReadLine();
            string command = Console.ReadLine();
            double taxes = 0.20;
            double priceWithTax = 0;
            double totalPriceWithoutTaxes = 0;
            double priceWithTaxForSpecial = 0;
            double totalPrice = 0;
            while (true)
            {
                if(command == "special" || command == "regular")
                {
                    break;
                }

                for (int i = 0; i < priceWithoutTax; i++)
                {

                    if (priceWithoutTax <= 0)
                    {
                        Console.WriteLine("Invalid price!");
                    }
                    else
                    {
                        taxes = priceWithoutTax * 0.20;
                        priceWithTax = priceWithoutTax * 0.20;
                        totalPriceWithoutTaxes = i++;
                    }
                       
                    

                    if (typeOfCustomer == "special")
                    {
                       priceWithTaxForSpecial = priceWithTax -= priceWithTax * 0.10;
                    }
                    totalPrice = (priceWithTax - priceWithTaxForSpecial) + priceWithTax;

                    if (totalPriceWithoutTaxes == 0)
                    {
                        Console.WriteLine("Invalid order!");
                    }
                }
                command = Console.ReadLine();

            }

            

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {(decimal)totalPriceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {(decimal)taxes:f2}$");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Total price: {(decimal)totalPrice:f2}$");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            double totalPrice = 0.00;
            
           


            while (true)
            {
                string command = Console.ReadLine();
                string[] cmdArg = command.Split();

                if (command == "end")
                {
                    break;
                }
                
                string serialNumber = cmdArg[0];
                string itemName = cmdArg[1];
               
                int itemQuantity = int.Parse(cmdArg[2]);
                double itemPrice = double.Parse(cmdArg[3]);
                totalPrice = itemPrice * itemQuantity;

                Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice, totalPrice);
                boxes.Add(box);
               

                command = Console.ReadLine();
            }

            List<Box>sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();
         
            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceBox:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:F2}");
            }
            
        }
    }
    
       
    }
    class Item
    {
        
    }
    class Box
    {
      public Box(string serialNumber, string item, int quantity, double priceBox, double totalPrice)
        {
            SerialNumber = serialNumber;
            
            Item = new Item();
            Quantity = quantity;
            PriceBox = priceBox;
            TotalPrice = totalPrice;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceBox { get; set; }

        public double TotalPrice { get; set; }

    public override string ToString()
    {

        return $"{SerialNumber} {Item} {Quantity} {PriceBox} {TotalPrice}";
    }

}

//{ boxSerialNumber}-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}-- ${ boxPrice}
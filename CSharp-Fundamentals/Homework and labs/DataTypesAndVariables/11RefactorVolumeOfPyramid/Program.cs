using System;

namespace _11RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, heigth= 0;
            Console.WriteLine($" Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.WriteLine($"Width: ;");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Heigth: ;");
            heigth = double.Parse(Console.ReadLine());
            double volumeOfPyramid = double.Parse(Console.ReadLine());
            volumeOfPyramid = (lenght + width + heigth) / 3;
            
            Console.WriteLine($"Pyramid Volume: {volumeOfPyramid:f2}");
        }
    }
}

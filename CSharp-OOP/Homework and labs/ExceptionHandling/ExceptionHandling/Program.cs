using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

           
            try
            {
                Person pesho = new Person("Pesho", "Peshev", 24);
                Person noName = new Person(string.Empty, "Goshev", 31);
                Person noLastName = new Person("Ivan", null, 63);
                Person negativeAe = new Person("Stoyan", "Kolev", -1);
                Person tooOldForThisProgram = new Person("Iskren", "Ivanow", 121);

            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            
        }
    }
}

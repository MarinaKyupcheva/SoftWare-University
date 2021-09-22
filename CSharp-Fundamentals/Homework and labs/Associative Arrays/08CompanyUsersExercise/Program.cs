using System;
using System.Collections.Generic;
using System.Linq;

namespace _08CompanyUsersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] cmdArg = command.Split(" -> ");
                string companyName = cmdArg[0];
                string employeeId = cmdArg[1];

                if (!output.ContainsKey(companyName))
                {
                    output.Add(companyName, new List<string> { employeeId });   

                }
                if(!output[companyName].Contains(employeeId))
                {
                    output[companyName].Add(employeeId);
                }
                
                

                    command = Console.ReadLine();
            }

            foreach (var company in output.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var item in company.Value)
                {
                       
                        Console.WriteLine($"-- {item}");
                    
                }
            }
        }
    }
}

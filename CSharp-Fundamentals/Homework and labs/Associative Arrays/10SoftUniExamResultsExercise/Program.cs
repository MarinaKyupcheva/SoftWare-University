using System;
using System.Collections.Generic;
using System.Linq;

namespace _10SoftUniExamResultsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            Dictionary<string, int> points = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] cmdArg = input.Split("-");
                string userName = cmdArg[0];
                string language = cmdArg[1];
                int point = int.Parse(cmdArg[2]);


                if(cmdArg.Length > 2)
                {
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language] += 1; 
                    }

                    if (!points.ContainsKey(userName))
                    {
                        points.Add(userName, point);

                        if(points[userName] < point)
                        {
                            points[userName] = point;
                        }
                    }
                    
                    
                }
                else
                {
                    
                        points.Remove(userName);
                    
                    

                  
                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Results:");
            foreach (var participant in points.OrderByDescending(v=>v.Value).ThenBy(k=>k.Key))
            {
                
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }

            Console.WriteLine($"Submissions:");
            foreach (var item in submissions.OrderByDescending(v=>v.Value).ThenBy(x=>x.Key))
            {
                
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}

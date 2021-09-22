using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ProblemExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> likes = new Dictionary<string, int>();
            Dictionary<string, int> comments = new Dictionary<string, int>();
            
            while (input != "Log out")
            {
                string[] cmdArg = input.Split(": ");
                string command = cmdArg[0];
                
                if(command == "New follower")
                {
                    string userName = cmdArg[1];
                    if (!likes.ContainsKey(userName))
                    {
                        likes.Add(userName, 0);
                        
                    }
                    if (!comments.ContainsKey(userName))
                    {
                        comments.Add(userName, 0);
                    }
                }

                else if(command == "Like")
                {
                    string userName = cmdArg[1];
                    int count = int.Parse(cmdArg[2]);

                    if (!likes.ContainsKey(userName))
                    {
                        likes.Add(userName, count);
                        comments.Add(userName, 0);

                    }
                    else
                    {
                        likes[userName] += count;
                    }
                    
                    
                    

                }
                else if(command == "Comment")
                {
                    string userName = cmdArg[1];
                    if (!comments.ContainsKey(userName))
                    {

                        likes.Add(userName, 1);
                        comments.Add(userName, 0);

                    }
                    else
                    {
                        comments[userName] += 1;
                    }
                    
                        
                    
                }
                else if(command == "Blocked")
                {
                    string userName = cmdArg[1];
                    if (likes.ContainsKey(userName))
                    {
                        likes.Remove(userName);
                        comments.Remove(userName);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{userName} doesn't exist!");
                    }
                        
                    

                }

                    input = Console.ReadLine();
            }

            Console.WriteLine($"{likes.Count} followers");

            
            foreach (KeyValuePair<string, int> kvpLikes in likes.OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key))
            {
                string userName = kvpLikes.Key;
                int likesCount = kvpLikes.Value;
                int commentsCount = comments[userName];
                int total = likesCount + commentsCount;
                Console.WriteLine($"{userName}: {total}");
            }
        }
    }
}

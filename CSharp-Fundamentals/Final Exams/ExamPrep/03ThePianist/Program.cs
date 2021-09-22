using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                pieces.Add(piece, new List<string>());
                pieces[piece].Add(composer);
                pieces[piece].Add(key);

            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] cmdArg = command.Split("|");
                string cmd = cmdArg[0];
                string piece = cmdArg[1];

                if(cmd == "Add")
                {
                    string composer = cmdArg[2];
                    string key = cmdArg[3];

                    if (!pieces.ContainsKey(piece))
                    {
                       pieces.Add(piece, new List<string>());
                        pieces[piece].Add(composer);
                        pieces[piece].Add(key);

                        Console.WriteLine($"{piece} by { composer} in { key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{ piece} is already in the collection!");
                    }

                }
                else if(cmd == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if(cmd == "ChangeKey")
                {
                    string newKey = cmdArg[2];

                    if (!pieces.ContainsKey(piece))
                    {


                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                       
                    }
                    else
                    {
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }


                command = Console.ReadLine();
            }

            pieces = pieces.OrderBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var piece in pieces)
            {
              
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {piece.Value}");
            }
            
        }
    }
}

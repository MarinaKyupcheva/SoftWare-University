using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ThePianist2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, string> piecesComposer = new Dictionary<string, string>();
            Dictionary<string, string> piecesKey = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] cmd = Console.ReadLine().Split("|");
                string piece = cmd[0];
                string composer = cmd[1];
                string key = cmd[2];

                if (!piecesComposer.ContainsKey(piece))
                {
                    piecesComposer[piece] = composer;
                    piecesKey[piece] = key;
                }

            }

            string input = Console.ReadLine();
            while(input != "Stop")
            {
                string[] cmdArg = input.Split("|");
                string command = cmdArg[0];
                string piece = cmdArg[1];

                if(command == "Add")
                {
                    string composer = cmdArg[2];
                    string key = cmdArg[3];

                    if (!piecesComposer.ContainsKey(piece))
                    {
                        piecesComposer[piece] = composer;
                        piecesKey[piece] = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");

                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if(command == "Remove")
                {
                    if (piecesComposer.ContainsKey(piece))
                    {
                        piecesComposer.Remove(piece);
                        piecesKey.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if(command == "ChangeKey")
                {
                    string newKey = cmdArg[2];

                    if (piecesKey.ContainsKey(piece))
                    {
                        piecesKey[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }


                input = Console.ReadLine();
            }
            var pieces = piecesComposer.OrderBy(x => x.Key).ThenBy(v => v.Value)
                .ToDictionary(x => x.Key, v => v.Value);

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {piecesKey[piece.Key]}");
            }
        }
    }
}

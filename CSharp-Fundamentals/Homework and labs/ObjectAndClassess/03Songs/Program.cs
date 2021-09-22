using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split("_");
                string typeList = command[0];
                string name = command[1];
                string time = command[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }
                string type = Console.ReadLine();
            
            //    if(type == "all")
            //    {
            //        Console.WriteLine(song.Name);
            //    }
                List<Song> filteredSongs = songs.Where(x => x.TypeList == type).ToList();
                foreach (Song song1 in filteredSongs)
                {
                    Console.WriteLine(song1.Name);
                }

           

              

            }
        }
    }
    class Song
    {
        public Song(string typeList,string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    
}


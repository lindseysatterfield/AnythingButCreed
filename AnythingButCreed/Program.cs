using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>();

            allSongs.Add(new Song("Creed", "With Arms Wide Open"));
            allSongs.Add(new Song("Creed", "Higher"));
            allSongs.Add(new Song("Creed", "My Sacrifice"));
            allSongs.Add(new Song("Backstreet Boys", "Larger than Life"));
            allSongs.Add(new Song("Backstreet Boys", "I Want It That Way"));
            allSongs.Add(new Song("Backstreet Boys", "Quit Playing Games"));
            allSongs.Add(new Song("NSYNC", "Bye Bye Bye"));
            allSongs.Add(new Song("NSYNC", "It's Gonna Be Me"));

            goodSongs = allSongs.Where(x => x.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}

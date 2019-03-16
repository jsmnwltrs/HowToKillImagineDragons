using System;
using System.Collections.Generic;
using System.Linq;

namespace HowToKillImagineDragons
{
    class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Song> allSongs = new List<Song>();
            List<Song> goodSongs = new List<Song>();

            allSongs.Add(new Song("Radioactive", "Imagine Dragons"));
            allSongs.Add(new Song("It's Time", "Imagine Dragons"));
            allSongs.Add(new Song("Walking the Wire", "Imagine Dragons"));
            allSongs.Add(new Song("Demons", "Imagine Dragons"));
            allSongs.Add(new Song("Believer", "Imagine Dragons"));
            allSongs.Add(new Song("Window Seat", "Erykah Badu"));
            allSongs.Add(new Song("Beat It", "Michael Jackson"));
            allSongs.Add(new Song("More Than a Woman", "BeeGees"));
            allSongs.Add(new Song("Higher", "Creed"));
            allSongs.Add(new Song("Canned Heat", "Jamiroquai"));
            allSongs.Add(new Song("Iron Man", "Black Sabbath"));

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Name} by {song.Artist} is great song!");
            }

            Console.ReadLine();
        }
    }
}

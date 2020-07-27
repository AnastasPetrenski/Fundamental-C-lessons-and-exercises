using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsNumber = int.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Song> playList = new List<Song>();
            while (input.Count > 1)
            {

                playList.Add(Song.ReadSongs(input));

                input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            if (input.Contains("all"))
            {
                for (int i = 0; i < playList.Count; i++)
                {
                    Song.PrintPlayList(playList[i]);
                }
            }
            else 
            {
                for (int i = 0; i < playList.Count; i++)
                {
                    Song.PrintPlayListCustom(playList[i], input[0]);
                }
            }

            List<Song> filteredSongs = playList.Where(x => x.TypeList == input[0]).ToList();
            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }

        }
    }

    
}

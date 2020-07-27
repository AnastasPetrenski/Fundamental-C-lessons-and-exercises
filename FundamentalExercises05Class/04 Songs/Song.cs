using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Songs
{
    public class Song
    {
        //1. Properties prop tab tab
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        //2. Constructor ctor tab tab
        public Song()
        {

        }

        //3. Methods
        public static Song ReadSongs(List<string> input)
        {
            Song list = new Song();
            list.TypeList = input[0];
            list.Name = input[1];
            list.Time = input[2];
            return list;
        }

        public static void PrintPlayList(Song playList)
        {
            Console.WriteLine(playList.Name);
        }

        public static void PrintPlayListCustom(Song playlist, string type)
        {
            if (playlist.TypeList == type)
            {
                Console.WriteLine(playlist.Name);
            }
        }
    }
}

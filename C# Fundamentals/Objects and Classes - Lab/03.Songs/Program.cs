namespace _03.Songs
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 1; i <= numbers; i++)
            {
                string[] currSong = Console.ReadLine().Split('_');
                string type = currSong[0];
                string name = currSong[1];
                string time = currSong[2];
                Song song = new Song()
                {
                    TypeList = type,
                    Name = name,
                    Time = time,
                };
                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                songs.ForEach(x => Console.WriteLine(x.Name));
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}

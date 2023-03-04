namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] commandArguments = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries);

                string type = commandArguments[0];
                string name = commandArguments[1];
                string time = commandArguments[2];

                Song newSong = new Song();

                newSong.TypeList = type;
                newSong.Name = name;
                newSong.Time = time;

                songs.Add(newSong);
            }
            string typelist = Console.ReadLine();

            if (typelist == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                //foreach (Song song in songs)
                //{
                //    if (song.TypeList == "typeList ")
                //    {
                //        Console.WriteLine(song.TypeList);
                //    }
                //}

                List<Song> filterListSongs = songs
                    .Where(x => x.TypeList == typelist)
                    .ToList();

                foreach (Song song in filterListSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }

    }
}


class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }

}
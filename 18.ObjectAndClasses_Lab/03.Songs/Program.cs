namespace _03.Songs
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split("_").ToList();
                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string printOption = Console.ReadLine();

            if (printOption == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == printOption)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}

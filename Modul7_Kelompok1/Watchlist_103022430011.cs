using System;
using System.IO;
using System.Text.Json;

namespace Modul7_Kelompok1
{
    internal class Watchlist_103022430011
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Movie> movies { get; set; }
    }

    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }

        public void ReadJSON1()
        {
            string json = File.ReadAllText("jurnal7_2_103022430011.json");
            Watchlist_103022430011 data = JsonSerializer.Deserialize<Watchlist_103022430011>(json);

            if (data != null)
            {
                Console.WriteLine($"Watchlist Name : {data.watchlistName}");
                Console.WriteLine($"Created By : {data.createdBy}");
                Console.WriteLine("Movies : ");
                foreach (var files in data.movies)
                {
                    Console.WriteLine($"{files.id} {files.title} ({files.year} - {files.rating}");
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7_Kelompok1
{
    internal class Watchlist_103022400015
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Movie> movies { get; set; }
    }

    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public double year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }
}

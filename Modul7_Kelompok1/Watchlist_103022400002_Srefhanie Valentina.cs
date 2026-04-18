using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Kelompok1
{
    internal class Watchlist_103022400002_Srefhanie_Valentina
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }

        public List<Movie>? movies { get; set; }

        
    }
    internal class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }
}

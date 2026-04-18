using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7_Kelompok1
{
    internal class Watchlist_103022430013_dwi
    {
        public string watchlistName {  get; set; }
        public string createdBy { get; set; }
        public List<movies> movie  { get; set; }
    }
}
public class movies
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating{ get; set; }
}

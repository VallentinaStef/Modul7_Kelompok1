using Modul7_Kelompok1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
class Program
{
    public static void Main(String[] args)
    {
        ReadJSON();
        ReadJSON1();
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\Modul7_Kelompok1\\Modul7_Kelompok1\\jurnal7_1_103022400015.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400015>(jsonString);
        Console.WriteLine(data);
    }

    public static void ReadJSON1()
    {
        string jsonString = File.ReadAllText("D:\\Modul7_Kelompok1\\Modul7_Kelompok1\\jurnal7_2_103022400015.json");
        var f = JsonSerializer.Deserialize<Watchlist_103022400015>(jsonString);
        Console.WriteLine($"Watchlist Name: {f.watchlistName}");
        Console.WriteLine($"Created By: {f.createdBy}");
        Console.WriteLine($"Movies: ");
        foreach ( var i in f.movies )
        {
            Console.WriteLine(i.id + " " + i.title + " " + i.year + " " + i.genre + " " + i.rating + " "); 
        }
    }
}

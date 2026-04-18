using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Modul7_Kelompok1;
class Program
{
    public static void Main(String[] args)
    {

        ReadJSON();
        ReadJSON2();
    }
    public static void ReadJSON() 
    {

        string json = File.ReadAllText("D:\\Modul7_Kelompok1\\Modul7_Kelompok1\\jurnal7_1_103022400002.json");
        var data = JsonSerializer.Deserialize<FilmFavorite_103022430013_dwi>(json);
        Console.WriteLine(data);
    }

    public static void ReadJSON2()
    {
        string json = File.ReadAllText("D:\\Modul7_Kelompok1\\Modul7_Kelompok1\\jurnal7_2_103022400002.json");
        var film = JsonSerializer.Deserialize<Watchlist_103022430013_dwi>(json);
        Console.WriteLine($"Watchlist Name :{film.watchlistName}");
        Console.WriteLine($"Created By :{film.createdBy}");
        Console.WriteLine($"Movie :");

        foreach (var films in film.movie)
        {
            Console.WriteLine(films.id + " " + films.title + " " + films.year);
        }
    }
}



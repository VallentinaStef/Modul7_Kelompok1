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
        string json = File.ReadAllText("jurnal7_1_103022400002.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400002_Stefhanie_Valentina>(json);    
        Console.WriteLine(data);
    }

    public static void ReadJSON2()
    {
        string json = File.ReadAllText("jurnal7_2_103022400002.json");
        var film = JsonSerializer.Deserialize<Watchlist_103022400002_Srefhanie_Valentina>(json);



        Console.WriteLine($"Watching Name :{film.watchlistName}");
        Console.WriteLine($"Created By: {film.createdBy}");
        Console.WriteLine($"Movies :");

        foreach (var films in film.movies)
        {
            Console.WriteLine(films.id + " " + films.title + " " + films.year);
        }
    }

    
}

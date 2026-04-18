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
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_103022400002.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400002_Stefhanie_Valentina>(json);    
        Console.WriteLine(data);
    }
}

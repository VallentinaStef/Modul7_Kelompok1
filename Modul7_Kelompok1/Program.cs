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
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\Modul7_Kelompok1\\Modul7_Kelompok1\\jurnal7_1_103022400015.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400015>(jsonString);
        Console.WriteLine(data);
    }
}

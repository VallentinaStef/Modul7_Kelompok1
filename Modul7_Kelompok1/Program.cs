using Modul7_Kelompok1;
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static void Main(String[] args)
    {
        FilmFavorit_103022430011 film = new FilmFavorit_103022430011();
        film.ReadJSON();
        Console.WriteLine("");
        Movie watch = new Movie();
        watch.ReadJSON1();
    }
}

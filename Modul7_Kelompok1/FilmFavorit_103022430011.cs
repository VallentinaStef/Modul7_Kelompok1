using System;
using System.IO;
using System.Text.Json;

public class FilmFavorit_103022430011
{

    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public int rating { get; set; }
    public int durationMinutes { get; set; }
    public Boolean isWatched { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_103022430011.json");
        FilmFavorit_103022430011? data = JsonSerializer.Deserialize<FilmFavorit_103022430011>(json);

        if (data != null )
        {
            Console.WriteLine($"Judul film adalah {data.title}, direktor filmnya {data.director}, rilis tahun {data.year}, genrenya {data.genre}, ratingnya {data.rating}, durasi filmnya {data.durationMinutes}, filmnya sudah ditonton?(true/false) {data.isWatched} ");
        }
    }
}

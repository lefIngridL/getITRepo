using System.IO;

namespace Par_2;

public class Construct
{
    public string title = string.Empty;
    public string genre = string.Empty;
    public string description = string.Empty;
    public string screenWriter = string.Empty;
    public string director = string.Empty;
    public string releaseDate = string.Empty;
    public double IMDB_Rating = 0;


    public void Add_Movie()
    {

        Console.WriteLine("oppgi tittel på film");
        title = Console.ReadLine();
        Console.WriteLine("oppgi sjanger på film");
        genre = Console.ReadLine();
        Console.WriteLine("oppgi beskrivelse på film");
        description = Console.ReadLine();
        Console.WriteLine("oppgi manusforfatter");
        screenWriter = Console.ReadLine();
        Console.WriteLine("oppgi direktør");
        director = Console.ReadLine();
        Console.WriteLine("oppgi lanseringsdato");
        releaseDate = Console.ReadLine();
        Console.WriteLine("oppgi IMDB rating");
        var IMDB_RatingStr = Console.ReadLine();
        IMDB_Rating = Convert.ToDouble(IMDB_RatingStr);
       
       
    }
     
}
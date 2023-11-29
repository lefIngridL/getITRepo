namespace Par_2;

public class Movie
{


    public string Title { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public string ScreenWriter { get; set; }

    public string Director { get; set; }

    public string ReleaseDate { get; set; }

    public double IMDB_Rating { get; set; }

    public Movie( string title, string genre, string description, string screenWriter, string director, string releaseDate, double imdbRating)
    {
        Description = description;
        Title = title;
        Genre = genre;
        ScreenWriter = screenWriter;
        Director = director;
        ReleaseDate = releaseDate;
        IMDB_Rating = imdbRating;
    }
}
﻿namespace Par_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Construct movie = new Construct();
            movie.Add_Movie();
            Console.WriteLine(movie.title);
            Movie Content = new Movie($"{movie.title}", $"{movie.genre}", $"{movie.description}", $"{movie.screenWriter}", $"{movie.director}", $"{movie.releaseDate}", movie.IMDB_Rating);
            Console.WriteLine(Content.Genre);

        }
    }
}

//Bok / Film - info
//Lag en applikasjon der man kan skrive inn forskjellige detaljer,
//og etter man har skrevet inn alt få printet tilbake det som ble
//skrevet inn som et “produkt”, enten en film eller en bok, dere velger.
//Man skal bli spurt av konsollen om Tittel, så år det kom ut,
//litt beskrivelse av hva filmen eller boken handler om, forfatter/regissør,
//hvilke skuespillere som var med.
//Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev
//inn som et produkt, med alle egenskaper listet opp.
//BONUS:
//Legg til mulighet for å skrive inn flere bøker eller filmer, her trenger man å ta i bruk lister
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LinqPlayground.Models;

namespace LinqPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<ChinookContext>(null);

            ChinookContext dbContext = new ChinookContext();
            var artistSearch = "Sabbath";
            var artists = dbContext.Artist.Where(a => a.Name.Contains(artistSearch));



            Console.WriteLine(artists);


            //Bring back 100 artist and order by name


            //Is there a genre for TV show?
            //var genreSearch = "TV";
            //var TVGenre = dbContext.Genre.Where(el => el.Name.Contains(genreSearch));
            //bool TVGenreExists = TVGenre.Count() > 0 ? true : false;
            //Console.WriteLine(TVGenreExists);
            //Console.WriteLine(artists);

            //List the artist on a particular album you like(hint, will need to create a 
            //new model and set up in Chinook context)

            //List all of the albums by your favorite artist.

            //List the total bill and mailing address for the following customers with 
            //an id of(10, 38, 57)

            //Create a class that will hold information regarding concerts you would like 
            //to attend.Create a list containing your concerts of choice.Set up several 
            //properties. Query your favorite concert list.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public decimal Stars { get; set; }
    }


    public class MovieRepository
    {
        //Pattern for data abstraction
        //All data looks like an array in memory
        //Get, Add, Update, Delete

        private static List<Movie> db = new List<Movie>
        {
            new Movie {Id = 1,  Title="Incredibles", Rating="PG", Stars= 4},
            new Movie {Id = 2,  Title="Deadpool", Rating="R", Stars= 4},
            new Movie {Id = 3,  Title="Sharknado", Rating="PG", Stars= 0},
            new Movie {Id = 4,  Title="Jurrasic Park", Rating="PG", Stars= 4},
            new Movie {Id = 5,  Title="Fifth Element", Rating="PG", Stars= 4},
            new Movie {Id = 6,  Title="Shrek", Rating="PG", Stars= 4},
            new Movie {Id = 8,  Title="Matrix", Rating="PG", Stars= 4},
            new Movie {Id = 9,  Title="Terminator", Rating="PG", Stars= 4},
            new Movie {Id = 10, Title="Avengers", Rating="PG", Stars= 4},
            new Movie {Id = 11, Title="Wonder Woman", Rating="PG", Stars= 4},
            new Movie {Id = 12, Title="Killer Clowns From Outer Space", Rating="PG", Stars= 1},
            new Movie {Id = 13, Title="Killer Tomatoes", Rating="PG", Stars= 2},
            new Movie {Id = 14, Title="Dark Knight", Rating="PG", Stars= 2},
        };

        public List<Movie> All()
        {
            return db;
        }

    }
}
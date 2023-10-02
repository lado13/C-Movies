using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies
{
    internal class MovieLibrary : MovieSystem, IMovies
    {
        private List<MovieSystem> movies;
        public MovieLibrary()
        {
            movies = new List<MovieSystem>()
            {
                new MovieSystem(){Title = "The Martian",DateOfShooting = new DateTime(2015,6,23), Director = "Ridley Scott", Genre = "Fantastic,Drama", IMDB = 7.2, Nationality = "USA"},
                new MovieSystem(){Title = "Intelstellar", DateOfShooting = new DateTime(2014,3,14), Director ="Christofer Nolan", Genre = "Fantastic,Drama", IMDB = 8.1, Nationality = "USA"}
            };
        }
        public void AddMovie(MovieSystem movie)
        {
            try
            {
                if (movies.Any(m => m.Title == movie.Title))
                {
                    Console.WriteLine("Movie already exists!!!");
                }
                else
                {
                    movies.Add(movie);
                    Console.WriteLine("Added Succesfully");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error adding movie: {ex.Message}");
            }
        }
        public void PrintMovie()
        {
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveMovie(string movieName)
        {
            try
            {
                MovieSystem remove = movies.Find(mov => mov.Title == movieName);
                if (remove != null)
                {
                    movies.Remove(remove);
                    Console.WriteLine("Movie removed!");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            catch (MetodsException ex)
            {
                Console.WriteLine($"Somting wrong! {ex}");
            }
        }      
        public List<MovieSystem> SearchMovie(string searchText)
        {
            return movies.Where(title => title.Title == searchText).ToList();
        }

        [Obsolete("This search will be remove!")]
        public List<MovieSystem> SearchMovieByIMDB(double searchMovieIMDB)
        {
            return movies.Where(movie => movie.IMDB >= searchMovieIMDB).ToList();
        }
        public void EditMovie(string title, MovieSystem updatedMovie)
        {
            try
            {
                MovieSystem movieToEdit = movies.FirstOrDefault(m => m.Title == title);
                if (movieToEdit != null)
                {
                    movieToEdit.Title = updatedMovie.Title;
                    movieToEdit.DateOfShooting = updatedMovie.DateOfShooting;
                    movieToEdit.Director = updatedMovie.Director;
                    movieToEdit.Nationality = updatedMovie.Nationality;
                    movieToEdit.Genre = updatedMovie.Genre;
                    Console.WriteLine("Edited succesfully");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error editing movie: {ex.Message}");
            }
        }
    }
}

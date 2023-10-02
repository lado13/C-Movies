using System.Collections.Generic;

namespace Movies
{
    internal interface IMovies
    {
        void PrintMovie();
        List<MovieSystem> SearchMovie(string searchText);
        void AddMovie(MovieSystem movie);  
        void RemoveMovie(string movieName);      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    internal class MovieSystem 
    {
        public string Title { get; set; }
        public DateTime DateOfShooting { get; set; }
        public string Director { get; set; }
        public string Nationality { get; set; }
        public string Genre { get; set; }
        public double IMDB { get; set; }


        public override string ToString()
        {
            return $"Name {Title}, Date {DateOfShooting.ToShortDateString()}, Director {Director}, IMDB {IMDB}, Nationality {Nationality}, Gener {Genre}";
            
        }

    }
}

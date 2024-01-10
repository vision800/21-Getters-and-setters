using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21__Getters_and_setters
{
    internal class Movie
    {
        public string title;
        public string diractor;
        public string rating;

        public Movie(string title, string diractor, string rating)
        {
            this.title = title;
            this.diractor = diractor;
            this.rating = rating;
        }

        public string Rating 
        {
            get{ return rating; }
            set{
            if( value=="G"|| value == "PG" || value == "PG-13" || value == "R" ) rating = value;
            else rating = "NR";
            }
        }
    }
}

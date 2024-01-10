using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21__Getters_and_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Titanic","vision","PG-13");
            Movie movie1 = new Movie("Catching fire", "vision", "PG");

            Console.WriteLine(movie1.rating);
            Console.Read();
        }
    }
}

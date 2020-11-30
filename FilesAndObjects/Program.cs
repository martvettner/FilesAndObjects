using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesAndObjects
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;
             
            public Movie(string atitle, string arating, string ayear)
            {
                title = atitle;
                rating = arating;
                year = ayear;
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\martv\Desktop\samples\imdb.txt";
            string fileName = @"C:\Users\martv\Desktop\samples\imdb.txt";
            List<string> movieList = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> listofMovies = new List<Movie>();

            foreach(string movieItem in movieList)
            {
                string[] tempArray = movieItem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);\

                listofMovies.Add(newMovie);
            }
            foreach(Movie movie in listofMovies)
            {
                Console.WriteLine("Title: " + movie.title, "rating: " + movie.rating, "Year: " + movie.year );
            }
        }
    }
}

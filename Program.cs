using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
          var movie = new Movie("Mad Max", "George Ogilvie");
          var book = new Book("Harry Potter and the philosopher's stone", "JK Rowling");
          var album = new Album("Anil Pak", "Le Wagon");
          
          Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
          
          album.Title = "Let it be!"
          Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
          
          Console.WriteLine("Book: " + book.Title + " by " + book.Author);
          
          Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);
        }
    }
}

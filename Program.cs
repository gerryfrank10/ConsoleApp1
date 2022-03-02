using System;

namespace ConsoleApp1
{
    class Program
    {
        struct Books
        {
            public String title;
            public String author;
            public String genre;
            public int id;
        }
        static void Main(String[] args)
        {
            Books book1;
            Books book2;

            book1.title = "This time tomorrrow";
            book1.author = "Medusa";
            book1.genre = "fiction";
            book1.id = 1;

            Console.WriteLine("Book {0} from author {1} is a {2} book ", book1.title, book1.author, book1.genre);
        }
    }
}
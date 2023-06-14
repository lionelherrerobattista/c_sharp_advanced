using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_advanced
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }

    }
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            // LINQ Query Operators -alternative syntax-
            //var cheaperBooks = from b in books // always start with from
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b.Title; // ends with select (b for all)

            // LINQ Extension Methods
            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b => b.Title); // linq

            // Single
            //var book = books.Single(b => b.Title == "ASP.NET MVC");
            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");

            //Console.WriteLine(book.Title);
            //Console.WriteLine(book == null);

            // First/Last
            //var book = books.First();
            //var book = books.First(b => b.Title == "C# Advanced Topics");
            //var book = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            //var book = books.Last(b => b.Title == "C# Advanced Topics");
            //var book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

            //Console.WriteLine(book.Title + " " + book.Price);

            // Skip/Take
            //var pagedBooks = books.Skip(2).Take(3);

            //foreach (var pagedBook in pagedBooks)
            //{
            //    Console.WriteLine(pagedBook.Title);
            //}

            //Aggregation
            //var count = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var sum = books.Sum(b => b.Price);
            var average = books.Average(b => b.Price);

            //Console.WriteLine(count);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(sum);
            Console.WriteLine(average);


            // without linq
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //foreach (var book in cheapBooks)
            //    Console.WriteLine(book);
            //Console.WriteLine(book.Title + " " + book.Price);
        }
    }
}

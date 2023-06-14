using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // delegate = args => expression 
            // () => ... no arguments
            // x => ... one argument
            // (x, y, z) => ... multiple arguments
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));

            //scope
            //const int factor = 5;

            //Func<int, int> multiplier = n => n * factor;

            //var result = multiplier(10);

            //Console.WriteLine(result);

            // real world example
            var books = new BookRepository().GetBooks();

            books.FindAll(book => book.Price < 10); 

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}

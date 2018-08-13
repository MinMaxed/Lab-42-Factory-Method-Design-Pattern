using DesignPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BookExample();
            Console.ReadKey();
        }

        static void BookExample()
        {
            Book book = null;

            BookShelf bookshelf = new BookShelf();
            book = BookFactory.CreateBook("mystery");
            Console.WriteLine("----");
            bookshelf.OrderBook("mystery");
        }
    }
}

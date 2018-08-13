using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    class BookShelf : BookStore
    {
        /// <summary>
        /// inherited Store function
        /// </summary>
        /// <param name="type">type of book to make</param>
        /// <returns>concrete book</returns>
        protected override Book CreateBook(string type)
        {
            Console.WriteLine($"Creating the {type} book");
            return BookFactory.CreateBook(type);
        }
    }
}

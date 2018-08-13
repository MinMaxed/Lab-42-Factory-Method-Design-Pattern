using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    public abstract class BookStore
    {
        
        protected abstract Book CreateBook(string type);

        /// <summary>
        /// Calls book methods
        /// </summary>
        /// <param name="type">type of book being made</param>
        /// <returns>concrete book</returns>
        public Book OrderBook(string type)
        {
            Book book = CreateBook(type);

            book.Print();
            book.Bind();
            book.Sell();

            return book;
        }
    }
}

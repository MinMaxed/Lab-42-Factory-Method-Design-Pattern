using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    public class BookFactory
    {
        /// <summary>
        /// Contcrete Book maker based on type
        /// </summary>
        /// <param name="bookType">type of book to make</param>
        /// <returns></returns>
        public static Book CreateBook(string bookType)
        {
            Book book = null;
            switch (bookType.ToLower())
            {
                case "scifi":
                    book = new SciFi();
                    break;
                case "western":
                    book = new Western();
                    break;
                case "mystery":
                    book = new Mystery();
                    break;
                default:
                    break;
            }
            return book;
        }
    }
}

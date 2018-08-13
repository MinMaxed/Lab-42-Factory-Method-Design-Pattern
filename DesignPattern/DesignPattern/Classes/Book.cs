using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    /// <summary>
    /// abstract class with its properties
    /// </summary>
    public abstract class Book
    {
        public void Print()
        {
            Console.WriteLine("Printing pages for the book");
        }

        public void Bind()
        {
            Console.WriteLine("Binding pages together");
        }

        public void Sell()
        {
        Console.WriteLine("Selling the book");
        }
    }
}

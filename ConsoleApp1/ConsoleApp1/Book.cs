using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        static int counter = 0;
        public int Id;
        public string BookName;
        public decimal Price;
        public int AuthorId;
        public Book(string BookName, decimal Price, int AuthorId)
        {
            this.Id = ++counter;
            this.BookName = BookName;
            this.Price = Price;
            this.AuthorId = AuthorId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BookOperation
    {
        List<Book> bookList = new List<Book>();
        public bool AddBook(string BookName,decimal Price, int AuthorId)
        {
            try
            {
                var data = new Book(BookName,Price,AuthorId);
                bookList.Add(data);
                Console.WriteLine(bookList.Count);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ListAuthorBook(int id)
        {
            var books = bookList.Where(x=>x.AuthorId == id).ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item.Id + " " + item.BookName + " " + item.Price + " " + item.AuthorId);
            }
        }

        public bool DeleteBook(int id)
        {
            try
            {
                var data = bookList.FirstOrDefault(x=>x.Id == id);
                bookList.Remove(data);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

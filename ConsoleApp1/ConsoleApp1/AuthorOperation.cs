using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AuthorOperation
    {
        List<Author> authorList = new List<Author>();
        public bool AddAuthor(string authorName, string authorEmail)
        {
            try
            {
                var data = new Author(authorName, authorEmail);
                authorList.Add(data);
                Console.WriteLine(authorList.Count);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ListAuthor()
        {
            foreach (var item in authorList)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Email);
            }
        }
    }
}

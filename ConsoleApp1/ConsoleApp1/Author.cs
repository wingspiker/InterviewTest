using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Author
    {
        static int counter = 0;
        public int Id;
        public string Name;
        public string Email;

        public Author(string Name, string Email)
        {
            this.Id = ++counter;
            this.Name = Name;
            this.Email = Email;
        }
    }
}

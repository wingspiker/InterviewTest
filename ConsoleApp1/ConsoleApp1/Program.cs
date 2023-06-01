namespace ConsoleApp1
{
    internal class Program
    {
        List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            AuthorOperation authorOperation = new AuthorOperation();
            BookOperation bookOperation = new BookOperation();
            Console.WriteLine("<<<< Library Management System >>>>");  
            while (true)
            {
                Console.WriteLine("1. Add Author");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. List Authors");
                Console.WriteLine("4. List Author Books");
                Console.WriteLine("5. Delete Book");
                Console.WriteLine("6. Delete Author");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter Name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        if (authorOperation.AddAuthor(Name, Email))
                        {
                            Console.WriteLine("Author Added");
                        }
                        else { Console.WriteLine("Author Not Added"); }
                        break;
                    case 2:
                        Console.WriteLine("Enter BookName");
                        string BookName = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        decimal Price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter AuthorId");
                        int AuthorId = Convert.ToInt32(Console.ReadLine());
                        if (bookOperation.AddBook(BookName,Price,AuthorId))
                        {
                            Console.WriteLine("Book Added");
                        }
                        else { Console.WriteLine("Book Not Added"); }
                        break;
                    case 3:
                        authorOperation.ListAuthor();
                        break;
                    case 4:
                        Console.WriteLine("Enter Author ID");
                        int id = Convert.ToInt32(Console.ReadLine());
                        bookOperation.ListAuthorBook(id);
                        break;
                    case 5:
                        Console.WriteLine("Enter Book ID");
                        int bookId = Convert.ToInt32(Console.ReadLine());
                        bookOperation.DeleteBook(bookId);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Enter Valid Input");
                        break;
                }
            }
            
        }
    }
}
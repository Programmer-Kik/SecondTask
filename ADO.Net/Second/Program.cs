using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthorsReader authorsReader = new AuthorsReader();
            BookReader bookReader = new BookReader();
            List<Author> authors;
            List<Book> books;

            try
            {
                authors = authorsReader.Read("Authors.txt");
                books = bookReader.Read("Books.txt");

                using (StreamWriter file = new StreamWriter("output.txt", false, Encoding.UTF8))
                {
                    foreach (var author in authors)
                    {
                        file.WriteLine(author.Info());
                    }

                    foreach(var book in books)
                    {
                        file.WriteLine(book.Info());
                    }
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
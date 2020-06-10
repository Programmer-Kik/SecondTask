using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Second
{
    public class BookReader
    {
        private bool IsBook(string[] str)
        {
            if (str[0] == "Book")
            {
                return true;
            }
            return false;
        }

        public List<Book> Read(string stringNameFile)
        {
            List<Book> books = new List<Book>();
            using (StreamReader file = new StreamReader(stringNameFile, Encoding.UTF8))
            {
                string[] booksString = file.ReadToEnd().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);


                foreach (var book in booksString)
                {
                    string[] str = book.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (IsBook(str))
                    {
                        StringBuilder nameOfBook = new StringBuilder();
                        int i = 1;
                        while(!int.TryParse(str[i], out int tmp))
                        {
                            nameOfBook.Append(str[i]);
                            if(!int.TryParse(str[i + 1], out int tmp0))
                            {
                                nameOfBook.Append(" ");
                            }
                            i++;
                        }

                        if (int.TryParse(str[i], out int amountOfPages) &&
                            int.TryParse(str[i + 2], out int dateOfPublishing) &&
                            int.TryParse(str[i + 3], out int dateOfWriting) &&
                            int.TryParse(str[i + 6], out int yearOfBirth))
                        {
                            books.Add(new Book(nameOfBook.ToString(), amountOfPages, str[i + 1], dateOfPublishing, dateOfWriting, 
                                new Author(str[i + 4], str[i + 5], yearOfBirth)));
                        }
                    }

                    if (!IsBook(str))
                    {
                        throw new Exception("This is not book, incorrect input format");
                    }
                }
            }

            return books;
        }
    }
}
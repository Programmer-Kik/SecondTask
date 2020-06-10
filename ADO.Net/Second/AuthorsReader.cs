using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Second
{
    public class AuthorsReader
    {
        private bool IsAuthor(string[] str)
        {
            if (str.Length == 4 && str[0] == "Author")
            {
                return true;
            }
            return false;
        }

        public List<Author> Read(string stringNameFile)
        {
            List<Author> authors = new List<Author>();
            using (StreamReader file = new StreamReader(stringNameFile, Encoding.UTF8))
            {
                string[] authorsString = file.ReadToEnd().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var author in authorsString)
                {
                    string[] str = author.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (IsAuthor(str))
                    {
                        if (int.TryParse(str[3], out int yearOfBirth))
                        {
                            authors.Add(new Author(str[1], str[2], yearOfBirth));
                        }
                    }

                    if (!IsAuthor(str))
                    {
                        throw new Exception("This is not author, incorrect input format");
                    }
                }
            }

            return authors;
        }
    }
}
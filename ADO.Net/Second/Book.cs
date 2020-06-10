using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Book
    {
        private readonly string name;
        private readonly int amountOfPages;
        private readonly string publishing;
        private readonly int dateOfPublishing;
        private readonly int dateOfWriting;
        private readonly Author author;

        public Book(string name, int amountOfPages, string publishing, 
            int dateOfPublishing, int dateOfWriting, Author author)
        {
            this.name = name;
            this.amountOfPages = amountOfPages;
            this.publishing = publishing;
            this.dateOfPublishing = dateOfPublishing;
            this.dateOfWriting = dateOfWriting;
            this.author = author;
        }

        public string Info()
        {
            return $@"Название: {name}, количество страниц: {amountOfPages}, издательство: {publishing}, дата публикации: {dateOfPublishing}, дата написания: {dateOfWriting}, автор: {author.Surname} {author.Name}";
        }
    }
}
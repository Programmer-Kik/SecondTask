using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Author
    {
        private readonly string name;
        private readonly string surname;
        public string Name => name;
        public string Surname => surname;

        private readonly int yearOfBirth;

        public Author(string name, string surname, int yearOfBirth)
        {
            this.name = name;
            this.surname = surname;
            this.yearOfBirth = yearOfBirth;
        }

        public string Info()
        {
            return $"Имя: {Name}, фамилия: {Surname}, год рождения: {yearOfBirth}";
        }
    }
}
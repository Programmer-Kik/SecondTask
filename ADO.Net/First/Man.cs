using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Man
    {
        protected readonly string name;
        protected readonly int age;
        protected readonly int weight;
        protected readonly int height;

        public Man(string name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public virtual string Info()
        {
            return $"Имя: {name}, возраст: {age}, вес: {weight}, возраст: {height}";
        }
    }
}
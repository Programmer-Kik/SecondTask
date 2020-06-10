using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Student: Man
    {
        protected readonly int yearOfEntrance;
        protected readonly int course;
        protected readonly int groupNumber;

        public Student(string name, int age, int weight, int height, 
            int yearOfEntrance, int course, int groupNumber):base(name, age, weight, height)
        {
            this.yearOfEntrance = yearOfEntrance;
            this.course = course;
            this.groupNumber = groupNumber;
        }

        public override string Info()
        {
            return $"Имя: {name}, возраст: {age}, вес: {weight}, возраст: {height}, год поступления: {yearOfEntrance}, курс: {course}, номер группы: {groupNumber}";
        }
    }
}

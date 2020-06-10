using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace First
{
    public class ManReader
    {
        private bool IsMan(string[] str)
        {
            if (str.Length == 5 && str[0] == "Man")
            {
                return true;
            }

            return false;
        }

        private bool IsStudent(string[] str)
        {
            if (str.Length == 8 && str[0] == "Student")
            {
               return true; 
            }

            return false;
        }

        public List<Man> Read(string fileName)
        {
            List<Man> mans = new List<Man>();

            using (StreamReader file = new StreamReader(fileName))
            {
                string[] mansString = file.ReadToEnd().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var man in mansString)
                {
                    string[] str = man.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (IsMan(str))
                    {
                        if (int.TryParse(str[2], out int age) && int.TryParse(str[3], out int weight) && int.TryParse(str[4], out int height))
                        {
                            mans.Add(new Man(str[1], age, weight, height));
                        }
                    }
                    
                    if (IsStudent(str))
                    {
                        if (int.TryParse(str[2], out int age) && int.TryParse(str[3], out int weight) && int.TryParse(str[4], out int height)
                            && int.TryParse(str[5], out int yearOfEntrance) && int.TryParse(str[6], out int course) && int.TryParse(str[7], out int groupNumber))
                        {
                            mans.Add(new Student(str[1], age, weight, height, yearOfEntrance, course, groupNumber));
                        }
                    }

                    if (!IsMan(str) && !IsStudent(str))
                    {
                        throw new Exception("This is not man or student, incorrect input format");
                    }
                }
            }

            return mans;
        }
    }
}
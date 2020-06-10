using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ManReader reader = new ManReader();
                List<Man> mans = reader.Read("input.txt");
                using (StreamWriter file = new StreamWriter("output.txt"))
                {
                    foreach(var man in mans)
                    {
                        file.WriteLine($"{man.Info()}");
                    }
                }
            }

            catch(Exception e)
            {
                Console.Write($"{e.Message}");
            }
        }
    }
}
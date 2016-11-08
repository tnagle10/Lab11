using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("tom","201");
            Staff s1 = new Staff("landon", "702", "dca", 12000);
            Student st1 = new Student("calvin", "702", "writing",2024,20.54);
            //test.Address="702";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(s1.ToString());
            Console.WriteLine(st1.ToString());
        }
    }
}

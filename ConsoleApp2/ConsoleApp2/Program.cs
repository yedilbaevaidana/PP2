using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        public Student(string n, string id, int year)
        {
            this.name = n;
            this.id = id;
            this.year = year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Aidana", "18BD111027", 1);
            Console.WriteLine(s1.name + " " + s1.id + " " + s1.year);
            Console.ReadKey();
        }
    }
}

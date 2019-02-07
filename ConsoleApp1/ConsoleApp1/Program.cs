using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Prime(int a)
        {
            if (a == 1) return false;
            for (int i=2; i<=Math.Sqrt (a); ++i)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;
            string result = " ";
            s = Console.ReadLine();
            string[] ss = s.Split(' ');
            for (int i=0; i<ss.Count(); i++)
            {
                if (Prime(int.Parse(ss[i])))
                {
                    result += ss[i] + " ";
                }
            }
            Console.WriteLine(result.Length / 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

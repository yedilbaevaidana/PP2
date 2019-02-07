using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ss = Console.ReadLine().Split(' ');
            int[] a = new int [1000];
            int j = 0;
            for(int i=0; i<ss.Count(); ++i)
            {
                a[j] = int.Parse(ss[i]); j++;
                a[j] = int.Parse(ss[i]); j++;
            }
            for (int i = 0; i<j; ++i)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

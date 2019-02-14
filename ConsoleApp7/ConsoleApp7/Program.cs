using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class MainClass
    {
        static string s = "    ";
        static void PrintInfo(DirectoryInfo dir, int k)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(s);
            }
            Console.Write(dir.Name);
            Console.WriteLine();
            var arr = dir.GetFileSystemInfos();
            foreach (var t in arr)
            {
                if (t.GetType() == typeof(DirectoryInfo))
                {
                    DirectoryInfo d = t as DirectoryInfo;
                    PrintInfo(d, k + 1);
                }
                if (t.GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 0; i < k; i++)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine(t.Name);
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\001\Desktop\PP2 задания");
            PrintInfo(di, 0);
        }
    }
}

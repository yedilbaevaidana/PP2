using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn = "thisFile.txt";
            string pathFrom = @"C:\Users\001\Desktop\PP2 задания";
            string pathTo = @"C:\Users\001\Desktop\PP2";
            string whereFrom = Path.Combine(pathFrom, fn);
            string shouldBe = Path.Combine(pathTo, fn);
            FileStream fs = File.Create(whereFrom);
            fs.Close();
            File.Copy(whereFrom, shouldBe, true);
            File.Delete(whereFrom);
        }
    }
}

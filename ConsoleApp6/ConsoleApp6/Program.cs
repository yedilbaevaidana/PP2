using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static bool CheckPrime(int x)
        {
            bool ok = true;
            if (x<=1)
            {
                ok = false; ;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\Users\001\Desktop\PP2\ConsoleApp6\input.txt.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            string[] chars = str.Split();
            int[] numbers = new int[chars.Length];
            for(int i = 0; i < chars.Length; i++)
            {
                numbers[i] = int.Parse(chars[i]);
            }
            FileStream fs2 = new FileStream(@"C:\Users\001\Desktop\PP2\ConsoleApp6\output.txt.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            for(int i = 0; i < numbers.Length; i++)
            {
                if (CheckPrime(numbers[i]) == true)
                {
                    sw.Write(numbers[i] + " ");
                }
            }
            sw.Close();
            fs2.Close();
            sr.Close();
            
        }
    }
}

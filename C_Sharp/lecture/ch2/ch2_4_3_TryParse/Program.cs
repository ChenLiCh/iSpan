using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_3_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入一個數字:");
                string input = Console.ReadLine();
                int number;
                bool IsNum = int.TryParse(input, out number);
                if (IsNum)
                {
                    Console.WriteLine("您輸入的數字是: " + number);
                }
                else
                {
                    Console.WriteLine("輸入無效，請輸入一個有效的數字");
                }
            }
        }
    }
}

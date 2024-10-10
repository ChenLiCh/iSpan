using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_5_IncrDecrOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;

            // 前遞增
            b = ++a; // a 先加 1，再將新的值給 b
            Console.WriteLine("前遞增: ");
            Console.WriteLine("a = " + a);// a=6
            Console.WriteLine("b = " + b);// b=6

            // 後遞增
            a = 5;
            b = a++; // 先將 a 的值給 b，再將 a 加 1
            Console.WriteLine("後遞增: ");
            Console.WriteLine("a = " + a);// a=6
            Console.WriteLine("b = " + b);// b=5

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12345678901234567890");
            Console.Write("a.{0}", 100);
            Console.Write("     b.{0}", -200);
            Console.WriteLine();
            Console.WriteLine("a.{0}     b.{1}", 100, -200);
            Console.ReadLine();
        }
    }
}

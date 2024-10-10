using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 邏輯運算子練習
            int k = 666;
            bool isTrue = k > 552;
            Console.WriteLine(isTrue && k < 1000);
            Console.WriteLine(isTrue || k > 1000);
            Console.WriteLine(!isTrue);
            Console.ReadLine();
        }
    }
}

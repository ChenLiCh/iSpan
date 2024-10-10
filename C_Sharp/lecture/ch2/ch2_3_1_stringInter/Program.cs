using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_1_stringInter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "長整數";
            int size = 8;
            string length = $"{2}個{data}資料佔{2 * size}位元組記憶體空間";
            Console.WriteLine(length);
            Console.ReadLine();
        }
    }
}

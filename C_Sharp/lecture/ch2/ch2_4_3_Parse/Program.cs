using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_3_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inn = 10;
            string strint = "123";

            // 把數字組成的字串，轉型成數字
            inn += int.Parse(strint);
            Console.WriteLine(inn);
            Console.ReadLine();
        }
    }
}

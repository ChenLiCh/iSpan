using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_1_4_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int souce = 100;
            double price = 822.23;
            char sex = 'M'; // 單引號 包起來的表示字元
            string str = "XXXXX"; // 雙引號 包起來的表示字串
            char c1 = '\u0061'; // \u 代表 Unicode
            char c2 = '中';
            string str2 = "123中文";

            Console.WriteLine("source: " + souce);
            Console.WriteLine("price: " + price);
            Console.WriteLine("sex: " + sex);
            Console.WriteLine("str: " + str);
            Console.WriteLine("c1: " + c1);
            Console.WriteLine("c2: " + c2);
            Console.WriteLine("str2" + str2);
            Console.ReadLine();
         }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 20;
            int k = 3;
            int i = j + k;
            Console.WriteLine(i);
            i = j - k;
            Console.WriteLine(i);
            i = j * k;
            Console.WriteLine(i);
            i = j / k;
            Console.WriteLine(i);
            i= j % k; // 取餘數
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

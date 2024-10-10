using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_2_cast3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b;
            char c;
            b = 65;

            // 將 byte 轉成 char，結果為對應的 ASCII 的字符 'A'
            c = (char)b;
            Console.WriteLine(c);

            int a = 65;
            Console.WriteLine(a);
            Console.WriteLine((char)a);
            Console.ReadLine();
        }
    }
}

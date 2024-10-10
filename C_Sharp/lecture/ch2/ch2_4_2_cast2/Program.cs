using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_2_cast2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            byte b;
            i = 255;
            b=(byte)i;
            Console.WriteLine(b);
            i = 256;
            b=(byte)i; // b=0 轉換值超過 byte 的範圍(0~255)
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_4_CompoundAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +=
            int x = 5;
            x += 3;
            Console.WriteLine("x+=3: " + x);

            // -=
            int y = 10;
            y -= 4;
            Console.WriteLine("y-=4: "+y);

            // *=
            int z = 2;
            z *= 5;
            Console.WriteLine("z*=5: "+ z);

            // /=
            int a = 20;
            a /= 4;
            Console.WriteLine("a/=4: " + a);

            // %=
            int b = 17;
            b %= 3;
            Console.WriteLine("b%=3: " + b);

            Console.ReadLine();
        }
    }
}

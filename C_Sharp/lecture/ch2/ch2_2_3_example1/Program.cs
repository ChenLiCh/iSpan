using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_3_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result1 = (4>3)&&('a' == 'b');
            Console.WriteLine(result1);

            bool result2 = (4>3)||('a'=='b');
            Console.WriteLine(result2);

            bool result3 = !(4 > 3);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}

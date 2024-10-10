using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_6_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = 7 + 6 * 8 / 3 % 7;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

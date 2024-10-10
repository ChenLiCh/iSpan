using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_6_Operator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            bool A = true, b = false, c = true;
            result = A && b || c;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

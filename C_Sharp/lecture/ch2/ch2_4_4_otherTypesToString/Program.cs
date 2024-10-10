using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_4_otherTypesToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 42;
            Console.WriteLine(number.ToString());

            double decimalNumber = 3.14;
            Console.WriteLine(decimalNumber.ToString());

            bool booleanValue = true;
            Console.WriteLine(booleanValue.ToString());

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());

            Console.ReadLine();
        }
    }
}

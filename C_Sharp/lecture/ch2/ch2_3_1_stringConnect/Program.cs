using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_1_stringConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1,str2;
            str1 = "同學A";
            str2 = str1 + "的成績是" + 89;
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_1_stringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "同學A";
            int score = 89;
            string data =string.Format("{0}的成績是{1}", name, score);
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}

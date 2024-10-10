using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_2_3_example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            bool isAgeInRange = (age >= 20) && (age < 60);
            Console.WriteLine("年齡介於 20~60之間: " + isAgeInRange);
            
            int score = int.Parse(Console.ReadLine());
            bool isScoreNonZero = score != 0;
            Console.WriteLine("成績不是0分? " + isScoreNonZero);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_2_ConsoleReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chinese, math;
            Console.WriteLine("請輸入你的姓名:");
            string name=Console.ReadLine();
            Console.WriteLine("Hi"+name+"您好，歡迎使用成績登入系統");
            Console.WriteLine("請輸入國文成績:");
            chinese=double.Parse(Console.ReadLine());
            Console.WriteLine("請輸入數學成績:");
            math = double.Parse(Console.ReadLine());
            Console.WriteLine($"平均為:{(chinese+math)/2}分");
            Console.Read();
        }
    }
}

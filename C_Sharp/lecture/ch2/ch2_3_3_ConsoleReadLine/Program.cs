using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_3_ConsoleReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("請輸入品名:");
            name = Console.ReadLine();
            int price = 0;
            Console.Write("請輸入單價:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine($"品名: {name} 單價: {price} 紀錄儲存成功");
            Console.ReadLine();
        }
    }
}

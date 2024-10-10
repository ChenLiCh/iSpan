using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.95, y = 2.65;
            
            // 將 double 轉成 int，結果為 0(因為小數部分被捨棄)
            int i=(int)x;

            // 將 double 轉成 int，結果為 0(因為小數部分被捨棄)
            int n =(int)y;
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}

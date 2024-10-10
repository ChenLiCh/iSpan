using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_2_cast1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double d = 9558.32;
            i = (int)d; // 9558
            // i = d; // 出現錯誤
        }
    }
}

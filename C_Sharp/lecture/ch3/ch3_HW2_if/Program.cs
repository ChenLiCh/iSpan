using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ch3_HW2_if {
    internal class Program {
        static void Main(string[] args) {
            string level = "";
            while (true) {
                Console.WriteLine("請輸入螢幕等級(4D, 3D, 其他): ");
                level=Console.ReadLine();
                if (level == "4D") Console.WriteLine("票價為: 500");
                else if (level == "3D") Console.WriteLine("票價為: 400");
                else if (level == "其他") Console.WriteLine("票價為: 300");
                else Console.WriteLine("請重新輸入");
            }
            
        }
    }
}

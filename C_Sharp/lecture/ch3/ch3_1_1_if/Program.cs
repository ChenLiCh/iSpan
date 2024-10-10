using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_1_1_if {
    internal class Program {
        static void Main(string[] args) {
            int age = 20;
            if (age >= 18) {
                Console.WriteLine("您已經成年，可以考駕照囉");
            } else {
                Console.WriteLine("您還未成年，不可考駕照囉");
            }
            Console.ReadLine();
        }
    }
}

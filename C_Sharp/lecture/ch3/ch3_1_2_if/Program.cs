using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_1_2_if {
    internal class Program {
        static void Main(string[] args) {
            int age = 0;
            while (true) {
                Console.Write("請輸入年齡: ");
                bool IsNum = int.TryParse(Console.ReadLine(), out age);
                if (IsNum) {
                    if (age >= 18) {
                        if (age >= 65) {
                            Console.WriteLine("您已經達到退休年齡");
                        } else {
                            Console.WriteLine("您是一位成年人，但還不能退休"); ;
                        }
                    } else {
                        Console.WriteLine("您還未成年，不能工作");
                    }
                } else {
                    Console.WriteLine("請輸入數字");
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_1_3_if {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("請輸入男生代號 M 或女生代號 F");
                string gender = Console.ReadLine();

                Console.WriteLine("請輸入您的年齡");
                string input2 = Console.ReadLine();

                int age = int.Parse(input2);

                if (age >= 18) {
                    if (gender == "M") {
                        Console.WriteLine("男性大人，要當兵囉");
                    } else if (gender == "F") {
                        Console.WriteLine("女性大人，不用當兵");
                    } else {
                        Console.WriteLine("成年，未知性別");
                    }
                } else {
                    if (gender == "M") {
                        Console.WriteLine("男性小孩，可能喜歡恐龍");
                    } else if (gender == "F") {
                        Console.WriteLine("女性小孩，可能喜歡公主");
                    } else {
                        Console.WriteLine("未成年，未知性別");
                    }
                }
            }

        }
    }
}

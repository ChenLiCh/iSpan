using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_HW3_if {
    internal class Program {
        static void Main(string[] args) {
            double weight = 0, height = 0, BMI = 0;
            string weightStr = "", heightStr = "";
            while (true) {
                Console.WriteLine("請輸入您的體重(公斤):");
                weightStr=Console.ReadLine();

                Console.WriteLine("請輸入您的身高(公分):");
                heightStr=Console.ReadLine();

                if (double.TryParse(weightStr, out weight) && double.TryParse(heightStr, out height)) {
                    BMI = weight / Math.Pow(height/100, 2);
                    if (BMI >= 35) Console.WriteLine($"您的BMI值為:{BMI,0:F2}\n重度肥胖");
                    else if (BMI >= 30) Console.WriteLine($"您的BMI值為:{BMI}\n中度肥胖");
                    else if (BMI >= 27) Console.WriteLine($"您的BMI值為:{BMI}\n輕度肥胖");
                    else if (BMI >= 24) Console.WriteLine($"您的BMI值為:{BMI}\n過重");
                    else if (BMI >= 18.5) Console.WriteLine($"您的BMI值為:{BMI,0:F2}\n正常");
                    else if (BMI < 18.5) Console.WriteLine($"您的BMI值為:{BMI}\n過輕");
                } else Console.WriteLine("請重新輸入");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_HW1_if {
    internal class Program {
        static void Main(string[] args) {
            string weather = ""; string temperatureStr = ""; float temperature = 0;
            while (true) {
                Console.Write("請輸入天氣狀況(晴天/雨天/其他): ");
                weather = Console.ReadLine();

                Console.Write("請輸入氣溫(攝氏度): ");
                temperatureStr = Console.ReadLine();

                float.TryParse(temperatureStr, out temperature);

                if (weather == "晴天") {
                    if (temperature > 25) Console.WriteLine("今天的天氣很熱，建議穿輕便的夏季服裝");
                    else if (temperature > 15) Console.WriteLine("天氣適中，建議穿輕薄的長袖衣物");
                    else Console.WriteLine("天氣較涼，建議穿暖和的長袖衣物或外套");

                } else if (weather == "雨天") {
                    if (temperature > 25) Console.WriteLine("雖然天氣炎熱，但仍然需要帶上雨具");
                    else if (temperature > 15) Console.WriteLine("建議穿防水外套和帶上雨具");
                    else Console.WriteLine("天氣寒冷且下雨，建議穿暖和的防水衣物和戴上雨具");

                } else {
                    Console.WriteLine("無法辨識天氣種類");
                }
            }
        }
    }
}

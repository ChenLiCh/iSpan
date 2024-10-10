using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_4_1_ImplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=100;
            long l=100;
            float f;
            double d=100;
            f = i; // 擴展轉換，允許自動轉換
            d = i; // 擴展轉換，允許自動轉換
            d = l; // 擴展轉換，允許自動轉換
            //i = d; // 縮小轉換，出現"無法將型別'double'隱含轉換成'int'"錯誤訊息
            //l = d; // 縮小轉換，出現"無法將型別'double'隱含轉換成'long'"錯誤訊息
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_3_3_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {0,0:C｝ 表示將索引 0 號參數（值為5）格式化為貨幣格式，寬度為 0
            // {1,0:c3｝ 表示將索引 1 號參數（值為-5）格式化為貨幣格式，寬度為 0，且有三位小數
            // {2,15:C3} 表示將索引 2 號參數（值為-5）格式化為貨幣格式，寬度為 15，且有三位小數
            // {3,-15:C3｝表示將索引 3 號參數（值為 - 5）格式化為貨幣格式，寛度為 -15，且有三位小數（負號表示左對齊)
            Console.WriteLine("{0,0:C} {1,0:c3}\n{2,15:C3}\n{3,-15:C3}", 5, -5, -5, -5);

            // 使用內插字串（string interpolation） 進行格式化輸出
            // {5,0:C｝表示將數值 5 格式化為貨幣格式，寬度為 0
            // ｛-5,0:c3｝表示將數值 -5 格式化為貨幣格式，寬度為 0，且有三位小數
            // ｛-5,15:C3｝表示將數值 -5 格式化為貨幣格式，寬度為 15，且有三位小數
            // ｛3,-15:C3｝表示將數值 3 格式化為貨幣格式，寬度為 -15，且有三位小數（負號表示左對齊）
            Console.WriteLine($"{5,0:C} {-5,0:c3}\n{-5,15:C3}\n{3,-15:C3}");
            Console.ReadLine();
        }
    }
}

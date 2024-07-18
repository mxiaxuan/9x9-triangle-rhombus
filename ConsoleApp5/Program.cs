using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //迴圈進階Loop
            //雙迴圈應用
            Console.WriteLine("**************************************************九九乘法表*******************************************************");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    string product = (i * j).ToString(); // 轉為字串可確定寬度
                    Console.Write($"{i}x{j}={product,-5} "); // 使用格式化字串，負號表示靠左對齊
                    string line = ("|").ToString(); //以|隔開
                    Console.Write($"{line,-3}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("********************************************************************************************************************");

            //三角形
            for (int j = 1; j <= 20; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===============================");

            int n = 8; // 菱形的行数

            // 上半部分菱形   
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            // 下半部分菱形
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}

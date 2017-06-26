using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = int.Parse(Console.ReadLine())/*入力した数字（文字）を数値に変換して代入*/;
                string y = "";

                while(x != 0)/*xが０じゃないとき繰り返す*/
                {
                    y = "ヽ(∴｀┏Д┓´)ﾉ彡#" + y;
                    x = x - 1;
                }
                Console.WriteLine(y);
                Console.WriteLine("------------------------------終わり------------------------------");
            }
        }
    }
}

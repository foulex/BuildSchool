using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01_3_CountString
{
    class Program
    {
        //計算個別字串數量☆☆
        static void Main(string[] args)
        {
            Console.Write("請輸入以空白隔開的英文字串：");
            string input = Console.ReadLine();
            var SA = input
                    .ToLower()
                    .Split(' ')
                    .GroupBy(x => x)
                    .Select(x => $@"{x.Key}有{x.Select(y => y).Count()}個");
            Console.WriteLine($"{string.Join(Environment.NewLine, SA)}");
            Console.ReadLine();
        }
    }
}

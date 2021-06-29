using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01_1
{
    class Program
    {

        /*內容替換☆
         * 使用Console.ReadLine() 讀取一個整數max(至少大於90)，在螢幕上用WriteLine 分行顯示1~ max，
         * 其中可被3 整除者替換為Build，可被5 整除者替換為School，可以被3 和5 同時整除者替換為Dann。*/

        static void Main(string[] args)
        {
            Console.Write("請輸入一個至少大於90的整數：");
            string input = Console.ReadLine();
            if (int.Parse(input) < 90)
            {
                Console.WriteLine($"{input}並未大於90。");
            }else
                for(int i = 1; i <= int.Parse(input); i++)
                {
                    if (i % 3 * 5 == 0)
                      { Console.WriteLine("Dann"); }
                    else if (i % 3 == 0)
                      { Console.WriteLine("Build"); }
                    else if (i % 5 == 0)
                      { Console.WriteLine("School"); }
                    else Console.WriteLine(i);
                }
            Console.ReadLine();
        }
    }
}

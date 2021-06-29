using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_LoopWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入字串，判斷是否回文：");
            string input = Console.ReadLine();
            int leng = input.Length;
 //           Console.WriteLine($"{leng}");
            if (leng > 1)
            {
                for (int i = 1; i <= (leng/2)+1; i++)
                {
                    if (input[i-1] != input[(leng - i)])
                    {
                        Console.WriteLine("此字串不回文");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("此字串回文");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("請輸入一個以上的字元。");
            }
 
            Console.ReadLine();

        }
    }
}

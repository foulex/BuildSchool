using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_03奇偶判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 老師寫法：
             * var result= string.Join(Envirment.NewLine,   //印出來，以換行分隔
             *             input.Split(',')                 //切割
             *            .Select(int.Parse)                //選擇，轉成整數，亦可用(x=>int.Parse(x))寫
             *            .OrderBy(x=>x)                    //排序
             *            .GroupBy(x=>x%2)                  //以餘數來分群，獲得群Key
             *            .OrderbyDescending(x=>x.Key)      //以Key排序(倒序)
             *            .Select(x=>string.Join(",",x)));  //印出來，以逗號分隔
             *            
             *            Console>WriteLine(result);
             */

            Console.WriteLine("請輸入任意長度的數字，並以逗號(,)分隔，我會按照奇偶數將其分開排列。");
            string input = Console.ReadLine();
            string[] result = input.Split(',');
            List<int> N_Odd = new List<int>(), N_Even = new List<int>();

            foreach (string check in result)
            {
                int i = int.Parse(check);

                if (i % 2 != 0) N_Odd.Add(i);
                else N_Even.Add(i);
            }
            N_Odd.Sort();
            N_Even.Sort();

            Console.Write("奇數：");
            //foreach(int i in N_Odd)     Console.Write($"{i},");
            Console.WriteLine($"{string.Join(",", N_Odd.Select(x => x))}");
            Console.WriteLine();

            Console.Write("偶數：");
            //foreach (int i in N_Even)   Console.Write($"{i},");
            Console.WriteLine($"{string.Join(",", N_Even.Select(x => x))}");
            Console.ReadLine();

        }
    }
}

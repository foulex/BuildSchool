using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_D2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("請輸入一個數字，我將判斷它是奇數還偶數：");
            //string  input   = Console.ReadLine();
            
            //if(input == "0")
            //{
            //    Console.WriteLine("0是例外，請重新輸入。");
            //}
            //else
            //{
            //    int result = int.Parse(input);
            //    if (result % 2 == 0)
            //    {
            //        Console.WriteLine("是偶數。");
            //    }
            //    else
            //    {
            //        Console.WriteLine("是奇數。");
            //    }
            //}        

            //Console.ReadLine();

            Console.Write("請輸入一個數字，我將判斷它是奇數還偶數：");
            Console.WriteLine((int.Parse(Console.ReadLine()))%2==0?"是偶數":"是奇數");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace H3_04_Translation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] Ans = new string[] {"零","壹","貳","參","肆","伍","陸","柒","扒","玖"};

            Console.Write("請輸入數字：");
            /*foreach(char CHAR in Regex.Replace(Console.ReadLine(),"[^0-9]",""))
            { Console.Write($"{Ans[int.Parse(CHAR.ToString())]}"); }
            Console.ReadLine();*/
            Console.WriteLine(string.Join("",Regex.Replace(Console.ReadLine(),"[^0-9]","").Select(x=>Ans[int.Parse(x.ToString())])));
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var NLists = new List<string>();
            //string NSL = "";

            Console.Write("請輸入一個整數：");
            int Nums = int.Parse(Console.ReadLine());
            for(int i = 0; i != Nums; i++)
            {
                string NS = (Nums-i).ToString();
                string NSL = "";
                for (int j = 0; j <= i; j++) 
                {
                    NSL = NSL + NS;
                }
                NLists.Add(NSL);       
            }
            foreach(string X in NLists) 
            {
                Console.WriteLine(X);
            }

            Console.ReadLine();
        }
    }
}

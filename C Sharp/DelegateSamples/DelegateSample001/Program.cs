using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample001
{
    public delegate void SomeAct(string mess);
    class Program
    {
        static void ShowT( string msg)
        { Console.WriteLine($"ShowT{msg}"); }
        static void ShowM(string str)
        { Console.WriteLine($"ShowM{str}"); }
        static void Main(string[] args)
        {
            //標準寫法
            SomeAct act1 = new SomeAct(ShowT);
            act1 += ShowM;
            //也可以這樣寫
            SomeAct act2 = ShowT;
            //標準寫法
            act1.Invoke("第一個");
            //也可以這樣寫
            act2("第二個");

            Console.ReadLine();
        }
    }
}

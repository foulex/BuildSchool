using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample001
{
    public enum MyWeekDays
    {
        Sun, Mon, Tue, Wen, Tur, Fri, Sat
    }
    public enum BrowserTypes
    {
        IE=1, Edge, Firefox, Chrome
    }

    public enum SwitchTypes
    {
        On=0, Off=1
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyWeekDays day = MyWeekDays.Sun;
            Console.WriteLine($"Today is {day}!");
            if (day == MyWeekDays.Mon)
            {
                Console.WriteLine("Today is Monday.");
            }
            else
            {
                Console.WriteLine("Today is not Monday.");
            }

            //轉換回int
            int i = (int)day;
            Console.WriteLine($"The vaule of {day} is {i}.");
            Console.ReadLine();
        }
    }
}

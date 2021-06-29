using System;
using RectangleLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int AWidth = 0, AHeight = 0;
            Console.Write($"請輸入寬：");
            Int32.TryParse(Console.ReadLine(), out AWidth);
            Console.Write($"請輸入高：");
            Int32.TryParse(Console.ReadLine(), out AHeight);
            Rectangle rect = new Rectangle() {Width = AWidth, Height=AHeight };

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample001
{
    class Program
    {
        static void Display(IShape shape)
        {
            Console.WriteLine($"這個形狀的面積是{shape.GetArea()}");
        }
        static void Main(string[] args)
        {
            IShape rect = new MyRect() { Width = 10, Height = 10 };
            Display(rect);
            IShape circle = new MyCircle() { Radius = 3 };
            Display(circle);

            Console.ReadLine();
        }
    }
}

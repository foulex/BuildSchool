using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample001
{
    class MyRect
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            //01
            Console.WriteLine($"object.Equals(i,j) is { object.Equals(i,j)}" );

            MyRect r01_1 = new MyRect { Width = 5, Height = 5 };
            MyRect r01_2 = new MyRect { Width = 5, Height = 5 };
            MyRect r01_3 = r01_2;
            Console.WriteLine($"object.Equals(r01_1,r01_2) is {object.Equals(r01_1, r01_2)}");
            Console.WriteLine($"object.Equals(r01_2,r01_3) is {object.Equals(r01_2, r01_3)}");
            Console.ReadLine();

            //02
            Console.WriteLine($"object.ReferenceEquals(i,i) is {object.ReferenceEquals(i, i)}");
            Console.WriteLine($"object.ReferenceEquals(i,j) is {object.ReferenceEquals(i, j)}");

            MyRect r02_1 = new MyRect { Width = 5, Height = 5 };
            MyRect r02_2 = new MyRect { Width = 5, Height = 5 };
            MyRect r02_3 = r02_2;

            Console.WriteLine($"object.ReferenceEquals(r02_1,r02_2) is {object.Equals(r02_1, r02_2)}");
            Console.WriteLine($"object.ReferenceEquals(r02_2,r02_3) is {object.Equals(r02_2, r02_3)}");
            Console.ReadLine();






        }
    }
}

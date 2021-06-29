using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample003
{
    public class MyRect : IEquatable<MyRect>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Equals(MyRect other)
        {
            Debug.WriteLine("Rect");
            return (this.Width == other.Width) && (this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            Debug.WriteLine("OBJ");
            return this.Equals((MyRect)obj);
        }

        public override int GetHashCode()
        {
            int hashCode = 859600377;
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(MyRect left, MyRect right)
        {
            return EqualityComparer<MyRect>.Default.Equals(left, right);
        }

        public static bool operator !=(MyRect left, MyRect right)
        {
            return !(left == right);
        }
        public override string ToString()
        {
            return $"寬：{Width},高：{Height}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine($"i.Equals(j)={i.Equals(j)}");
            MyRect r1 = new MyRect { Width = 5, Height = 5 };
            MyRect r2 = new MyRect { Width = 5, Height = 5 };
            MyRect r3 = r2;
            Console.WriteLine($"r1.Equals(r2)={r1.Equals(r2)}");
            Console.WriteLine($"r2.Equals(r3)={r2.Equals(r3)}");
            Console.WriteLine(r1.ToString());

            Console.ReadLine();

        }

    }
}

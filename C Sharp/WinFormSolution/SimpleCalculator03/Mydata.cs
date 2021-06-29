using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    class Mydata
    {
        private int Ax;
        private int Ay;

public int Bx
{
   get { return Ax; }
    set { Ax = value; }
}
public int By
        {
            get { return Ay; }
            set { Ay = value; }
        }

        public int Add(int Ax, int Ay)
        {
            return Ax + Ay;
        }

        public int Less(int Ax, int Ay)
        {
            return Ax - Ay;
        }
            

    }
}

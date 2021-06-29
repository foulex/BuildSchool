using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services
{
    public class CircleServices : IShapeServices
    {
        public Circle Target { get; set; }
        public double ComputeArea()
        {
            return Math.PI * Math.Pow(Target.Radius, 2);
        }

        public double ComputePerimeter()
        {
            return 2 * Math.PI * Target.Radius;
        }
    }
}

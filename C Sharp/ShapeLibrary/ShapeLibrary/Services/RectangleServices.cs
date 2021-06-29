using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services
{
    public class RectangleServices : IShapeServices
    {
        public Rectangle Target { get; set; }
        public double ComputeArea()
        {
            return Target.Width * Target.Height;
        }

        public double ComputePerimeter()
        {
            return (Target.Width + Target.Height) * 2;
        }
    }
}

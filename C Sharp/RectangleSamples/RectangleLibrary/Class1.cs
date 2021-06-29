using System;

namespace RectangleLibrary
{

    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class RectangleOperation
    {
        public Rectangle Target { get; set; }
        public int ComputeArea()
        { return Target.Width * Target.Height; }
    }
    public class RectangleOperationHelper
    {
        public static int ComArea(Rectangle input)
        {
            return input.Width * input.Height;
        }
    }
    public static class RectangleOperationExtension
    {
        public static int CArea(this Rectangle input)
        {
            return input.Width * input.Height;
        }
    }
}

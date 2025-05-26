using System;

namespace geometry_area_calculator_oop_cs
{
    /// <summary>
    /// Represents a rectangle shape.
    /// </summary>
    public class Rectangle : Shape, IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, double width, double height)
            : base(name)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}

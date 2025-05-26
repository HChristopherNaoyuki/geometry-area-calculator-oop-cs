using System;

namespace geometry_area_calculator_oop_cs
{
    /// <summary>
    /// Represents a circle shape.
    /// </summary>
    public class Circle : Shape, IShape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius)
            : base(name)
        {
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

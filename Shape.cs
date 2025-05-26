using System;

namespace geometry_area_calculator_oop_cs
{
    /// <summary>
    /// Abstract base class for geometric shapes.
    /// </summary>
    public class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Displays the shape's name.
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}

using System;

namespace geometry_area_calculator_oop_cs
{
    /// <summary>
    /// Contains core shape logic and display functionality.
    /// </summary>
    public static class Solution
    {
        /// <summary>
        /// Creates a rectangle, calculates its area, and displays the result.
        /// </summary>
        public static void DisplayRectangle(string name, double width, double height)
        {
            Rectangle rectangle = new Rectangle(name, width, height);
            rectangle.Display();
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }

        /// <summary>
        /// Creates a circle, calculates its area, and displays the result.
        /// </summary>
        public static void DisplayCircle(string name, double radius)
        {
            Circle circle = new Circle(name, radius);
            circle.Display();
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        }
    }
}

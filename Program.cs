using System;

namespace geometry_area_calculator_oop_cs
{
    /// <summary>
    /// Handles user interactions and program execution.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and display a rectangle
            Solution.DisplayRectangle("My Rectangle", 5, 10);

            // Create and display a circle
            Solution.DisplayCircle("My Circle", 7);

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}

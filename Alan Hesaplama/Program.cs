using System;

namespace Alan_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the shape (Circle, Triangle, Square, Rectangle): ");
            string shape = Console.ReadLine();

            double conclusion = 0;

            switch (shape.ToLower())
            {
                case "Circle":
                    Console.Write("Enter the radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    conclusion = Circle_around_Calculate(radius);
                    Console.WriteLine($"Circumference of the circle: {conclusion:F2}");
                    break;

                case "Triangle":
                    Console.Write("Enter the base: ");
                    double base_length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height:");
                    double height = Convert.ToDouble(Console.ReadLine());
                    sonuç = Triangle_Area_Calculate(base_length, height);
                    Console.WriteLine($"area of triangle: {conclusion:F2}");
                    break;

                case "Square":
                    Console.Write("Enter the side length: ");
                    double edge_length = Convert.ToDouble(Console.ReadLine());
                    conclusion = Square_Area_Calculate(edge_length);
                    Console.WriteLine($"Area of the square: {conclusion:F2}");
                    break;

                case "Rectangle":
                    Console.Write("Enter the length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    double Width = Convert.ToDouble(Console.ReadLine());
                    conclusion = Rectangle_Area_Calculate(length, Width);
                    Console.WriteLine($"Area of rectangle: {conclusion:F2}");
                    break;

                default:
                    Console.WriteLine("Invalid shape. Please try again.");
                    break;
            }

            Console.ReadLine();
        }

        static double Circle_around_Calculate(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static double Triangle_around_Calculate(double base_length, double height)
        {
            return 0.5 * base_length * height;
        }

        static double Square_around_Calculate(double edge_length)
        {
            return edge_length* edge_length;
        }

        static double Rectangle_around_Calculate(double length, double Width)
        {
            return length * Width;
        }
    }
}

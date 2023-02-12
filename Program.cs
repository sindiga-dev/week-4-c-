//from the NewClass.cs file create a c# console application that uses your classes to compute the area and perimeter of the various shapes using dummy values. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("The area of the circle is: " + circle.GetArea());
            Console.WriteLine("The perimeter of the circle is: " + circle.GetPerimeter());

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("The area of the rectangle is: " + rectangle.GetArea());
            Console.WriteLine("The perimeter of the rectangle is: " + rectangle.GetPerimeter());

            Square square = new Square(5);
            Console.WriteLine("The area of the square is: " + square.GetArea());
            Console.WriteLine("The perimeter of the square is: " + square.GetPerimeter());

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_4
{
      class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public double GetArea()
        {
            return Length * Width;
        }
    }

    class Square
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
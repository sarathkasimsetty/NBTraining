using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Write example program for interfaces discussed in the class IShape
//include the classes Cricle, Square, Triangle, Rectangle
namespace Day11Project3
{
    /// <summary>
    /// Interface class id shape in Abstarct methods to must override in derived all classes
    /// </summary>
    interface Ishape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }

    class Circle:Ishape
    {
        private int radius;
        /// <summary>
        /// Read value from user
        /// </summary>
        public void ReadRadius()
        {
            Console.WriteLine("********CIRCLE********");
            Console.WriteLine("Enter the circle radius");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            return 22*radius*radius/7;
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        } 
    }
    class Square : Ishape
    {
        private int side;
        /// <summary>
        /// Read value from user
        /// </summary>
        public void ReadSides()
        {
            Console.WriteLine("*******SQUARE******");
            Console.Write("Enter side of a Triangle: ");
            side = Convert.ToInt32(Console.ReadLine());
            
        }
        public int CalculateArea()
        {
            return 4 * side;
        }

        public int CalculatePerimeter()
        {
            return side * side;
        }
    }

    class Rectangle : Ishape
    {
        private int l;
        private int b;

        /// <summary>
        /// Read value from user
        /// </summary>
        public void ReadSide()
        {
            Console.WriteLine("*******RECTANGLE******");
            Console.Write("Enter Length of a Rectangle: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of a Rectangle: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 2*(l+b);
        }

        public int CalculatePerimeter()
        {
            return l*b;
        }
    }

    class Triangle : Ishape
    {
        private int s1;
        private int s2;
        private int s3;
        /// <summary>
        /// Read value from user
        /// </summary>
        public void ReadSides()
        {
            Console.WriteLine("******TRIANGLE******");
            Console.Write("Enter s1 of a Triangle: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter s2 of a Triangle: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter s3 of a Triangle: ");
            s3 = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return s1 + s2 + s3;
        }

        public int CalculatePerimeter()
        {
            double semiperimeter = (s1 + s2 + s3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - s1) * (semiperimeter - s2)* (semiperimeter - s3));
            return Convert.ToInt32(Area);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.ReadRadius();
            Console.WriteLine("***** CIRCLE******");
            Console.WriteLine($"The Perimeter of Circle is: {circle.CalculatePerimeter()}");
            Console.WriteLine($"The Area of Circle is:{circle.CalculateArea()}");

            Square squ = new Square();
            squ.ReadSides();
            Console.WriteLine("*****SQUARE*****");
            Console.WriteLine($"The Perimeter of Square is:{squ.CalculatePerimeter()}");
            Console.WriteLine($"The Area of Square is:{squ.CalculateArea()}");

            Rectangle rectangle = new Rectangle();
            rectangle.ReadSide();
            Console.WriteLine("*****RECTANGLE***");
            Console.WriteLine($"The Perimeter of a Rectangle is:{ rectangle.CalculatePerimeter()}");
            Console.WriteLine($"The Area of a Rectangle is:{rectangle.CalculateArea()}");

            Triangle triangle = new Triangle();
            triangle.ReadSides();
            Console.WriteLine("****TRIANGLE****");
            Console.WriteLine($"The Perimeter of a given Triangle is:{triangle.CalculatePerimeter()}");
            Console.WriteLine($"The Area of a Triangle is: {triangle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}

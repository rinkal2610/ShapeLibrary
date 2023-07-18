using AreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            Console.WriteLine("choose shape\n1:rectangle\n2.square\n3.circle\n4.triangle");
            int c=int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:
                    {
                        Console.WriteLine("enter length");
                        double length=double.Parse(Console.ReadLine());
                        Console.WriteLine("enter breadth");
                        double breadth = double.Parse(Console.ReadLine());
                        area = Rectangle.Area(length, breadth);
                        Console.WriteLine("area of rectangle= "+ area);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("enter side");
                        double side = double.Parse(Console.ReadLine());
                        area = Square.Area(side);
                        Console.WriteLine("area of square= "+ area);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("enter radius");
                        double radius = double.Parse(Console.ReadLine());
                        area = Circle.Area(radius);
                        Console.WriteLine("area of circle= "+ area);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("enter base");
                        double basee = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter height");
                        double height = double.Parse(Console.ReadLine());
                        area = Traingle.Area(basee,height);
                        Console.WriteLine("area of triangle= "+ area);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("wrong choice");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}

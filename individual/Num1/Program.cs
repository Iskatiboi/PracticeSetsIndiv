using System;
using System.Reflection.Metadata.Ecma335;

namespace Num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter side A: ");
          double a = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter side b: ");
          double b = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter side c: ");
          double c = Convert.ToDouble(Console.ReadLine());

          double area = Area(a, b, c);

          Console.WriteLine("The  area of the triangle is: " + area);

        }

        static double Sides(double a, double b, double c)
        {

         return (a + b + c)/2;

        }

        static double Area (double a, double b, double c)
        {
          double s = Sides(a, b, c);
          return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }


    }
}
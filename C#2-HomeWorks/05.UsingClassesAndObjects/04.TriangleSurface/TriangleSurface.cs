//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
using System;
    class TriangleSurface
    {
        static double CalculateWithAltitude(double altitude , double h)
        {
            return (altitude * h) / 2;
        }
        static double CalculateWithThreeSides(double a , double b , double c )
        {
            double pythag = (a + b + c) / 2;
            return Math.Sqrt(pythag * (pythag - a) * (pythag - b) * (pythag - c));
        }
        static double CalculateWithTwoSidesAndAngleBetweenThem(double a , double b , double angle)
        {
            return (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
        }
        static void Main()
        {
            Console.WriteLine(CalculateWithAltitude(altitude: 5, h: 8));
            Console.WriteLine(CalculateWithThreeSides(a: 5, b: 5, c: 8));
            Console.WriteLine(CalculateWithTwoSidesAndAngleBetweenThem(a: 3, b: 4, angle: 90));
        }
    }


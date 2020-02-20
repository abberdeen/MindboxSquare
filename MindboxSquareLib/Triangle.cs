using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxSquareLib
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c) : base (FigureType.Triangle)
        {
            A = a;
            C = b;
            B = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override double CalculateSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular() 
        {
            bool isRectangular = Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2) ||
                                 Math.Pow(B, 2) == Math.Pow(C, 2) + Math.Pow(A, 2) ||
                                 Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
            return isRectangular;
        }
    }
}

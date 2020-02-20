using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxSquareLib
{
    public class Circle : Figure
    {
        public Circle(double radius) : base (FigureType.Circle)
        {
            this.Radius = radius; 
        }

        public double Radius { get; set; } 

        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

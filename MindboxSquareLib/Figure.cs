using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxSquareLib
{
    public abstract class Figure : IFigure
    { 
        
        protected Figure(FigureType _shapeType)
        {
            ShapeType = _shapeType;
        }

        public FigureType ShapeType { get; }

        public abstract double CalculateSquare();
    }

    public enum FigureType
    {
        Circle,
        Triangle
    }
}

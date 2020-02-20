using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxSquareLib
{
    public interface IFigure 
    {
        FigureType ShapeType { get; }

        double CalculateSquare(); 
    }
}

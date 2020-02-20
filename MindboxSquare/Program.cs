using MindboxSquareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Triangle(6, 10,8);
            Console.WriteLine(figure.CalculateSquare());
            Console.WriteLine((figure as Triangle).IsRectangular());
            Console.ReadLine();
        }
    }
}

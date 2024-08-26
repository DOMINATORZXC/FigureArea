using FigureTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTypes.Figures
{
    public class Triangle : IFigure, ITriangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle(double A, double B, double C) 
        {
            a = A; 
            b = B; 
            c = C;
        }
        public double CalcArea()
        {
            double P = (a + b + c) / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
        public bool IsRightTriangle()
        {
            double[] sides = new double[] { a, b, c };
            
            Array.Sort(sides);

            double aSquare = Math.Pow(sides[0], 2);
            double bSquare = Math.Pow(sides[1], 2);
            double cSquare = Math.Pow(sides[2], 2);

            return Math.Abs(cSquare -(bSquare + aSquare)) < 1e-10;
        }
    }
}

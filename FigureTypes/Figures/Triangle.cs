using FigureTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTypes.Figures
{
    public class Triangle : IFigure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle(double A, double B, double C) {
            a = A; 
            b = B; 
            c = C;
        
        }
        public double CalcArea()
        {
            double P = (a + b + c) / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
    }
}

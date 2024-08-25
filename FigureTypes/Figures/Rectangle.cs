using FigureTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTypes.Figures
{
    public class Rectangle : IFigure
    {
        public double a { get; set; }
        public double b { get; set; }
        public Rectangle(double A , double B) 
        {
            a = A;
            b = B;           
        }
        public double CalcArea()
        {
           return a * b;
        }
    }
}

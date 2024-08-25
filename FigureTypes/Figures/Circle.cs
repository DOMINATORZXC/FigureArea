using FigureTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTypes.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }
        public double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

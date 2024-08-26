using FigureTypes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Test
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleCalcAreaCurrValue()
        {
            double A = 4;
            double B = 5;
            double C = 2;
            double P = (A + B + C) / 2;
            double expectedResult = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            Triangle triangle = new Triangle(A,B,C);

            double actualArea= triangle.CalcArea();

            Assert.Equal(expectedResult, actualArea, precision: 5);
        }

        [Theory]
        [InlineData(5,5, 7.071067811865475, true)]
        [InlineData(3, 2, 13, false)]
        [InlineData(10, 8, 12.8062484748657, true)]
        [InlineData(7, 6, 9, false)]

        public void IsRightTriangleCurrValue(double a, double b, double c, bool expectedResult)
        {
            Triangle triangle = new Triangle(a,b,c);

            bool IsRightTriangle = triangle.IsRightTriangle();

            Assert.Equal(expectedResult, IsRightTriangle);

        }
    }
}

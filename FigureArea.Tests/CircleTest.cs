using FigureTypes.Figures;
using Xunit;

namespace FigureArea.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Circle_CalcArea_ReturnCorrValue()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            double actualArea = circle.CalcArea();

            Assert.Equal(expectedArea, actualArea, precision: 5);
        }
    }
}

using FigureTypes.Figures;

namespace FigureArea.Test
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

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        [InlineData(0, 0)]

        public void Circle_DiffRadius_ReturnCorrValue(double radius, double expectedArea)
        {
            Circle circle = new Circle(radius);

            double actualArea = circle.CalcArea();

            Assert.Equal(expectedArea, actualArea,precision: 5);
        }
    }
}
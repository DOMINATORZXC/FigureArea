using FigureTypes.Figures;
using FigureTypes.Interfaces;

namespace Methods.FigureArea
{
    public static class FigureFactory
    {
        public static IFigure CreateFigure(string figureType, params double[] parameters)
        {
            switch (figureType.ToLower())
            {
                case "circle":
                    return new Circle(parameters[0]);
                case "triangle":
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                case "square":
                    return new Square(parameters[0], parameters[1]);
                case "rectangle":
                    return new Rectangle(parameters[0], parameters[1]); 
                default:
                    throw new ArgumentException("Unknown figure type");
            }
        }
    }
}
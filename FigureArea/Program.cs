using FigureTypes.Interfaces;
using Methods.FigureArea;
using System.Transactions;

Console.WriteLine("Enter figure type:");
Console.WriteLine("circle/square/triangle/rectangle");
string figureType  = Console.ReadLine();

IFigure figure = null;

switch(figureType.ToLower()) 
{
    case "circle":
        Console.WriteLine("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        figure = FigureFactory.CreateFigure("circle", radius);
        break;
    case "triangle":
        Console.WriteLine("Enter side A");
        double triangleA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side B");
        double triangleB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side C");
        double triangleC = Convert.ToDouble(Console.ReadLine());
        figure = FigureFactory.CreateFigure("triangle",triangleA,triangleB,triangleC);
        break;
    case "square":
        Console.WriteLine("Enter side A");
        double squareA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side B");
        double squareB = Convert.ToDouble(Console.ReadLine());
        if(squareA == squareB)
        {
            figure = FigureFactory.CreateFigure("square", squareA, squareB);
        }
        else
        {
            Console.WriteLine("It is rectangle");
            figure = FigureFactory.CreateFigure("rectangle", squareA, squareB);
        }
        break;
    case "rectangle":
        Console.WriteLine("Enter side A");
        double rectangleA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side B");
        double rectangleB = Convert.ToDouble(Console.ReadLine());
        if (rectangleA != rectangleB)
        {
            figure = FigureFactory.CreateFigure("rectangle",rectangleA, rectangleB);
        }
        else
        {
            Console.WriteLine("It is square");
            figure = FigureFactory.CreateFigure("square", rectangleA, rectangleB);
        }
        break;
    default:
        Console.WriteLine("Unknown figure type");
        break;
}

double area = figure.CalcArea();
Console.WriteLine($"Area equal: {area}");
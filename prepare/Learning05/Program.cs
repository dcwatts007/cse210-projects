using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.Color = "Purple";
        square.Side = 10.5;
        Rectangle rectangle = new Rectangle();
        rectangle.Color = "Blue";
        rectangle.Width = 5000.2;
        rectangle.Length = .005;
        Circle circle = new Circle();
        circle.Color = "Pink";
        circle.Radius = 20.3;
        List<Shape> shapes = new List<Shape>
        {square,rectangle,circle};
        foreach (Shape item in shapes)
        {
            Console.WriteLine("A " + item.GetType() + " that's " + item.Color + " and has an area of " + item.GetArea());
        }
    }
}
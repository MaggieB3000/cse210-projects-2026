using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();

        Square Square = new Square(20, "red");
        shapesList.Add(Square);
        Rectangle Rectangle = new Rectangle(20, 30, "blue");
        shapesList.Add(Rectangle);
        Circle Circle = new Circle(10, "yellow");
        shapesList.Add(Circle);

        foreach (Shape shape in shapesList)
        {
            Console.WriteLine($"{shape.GetColor()} - {shape.GetArea()}");
        }
    }
}
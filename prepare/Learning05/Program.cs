using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Black", 10);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("White", 10, 10);
        shapes.Add(rectangle);

        Circle circle = new Circle("Gray", 2);
        shapes.Add(circle);

        foreach (Shape figurasGeometricas in shapes)
        {
            string color = figurasGeometricas.GetColor();
            double area = figurasGeometricas.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
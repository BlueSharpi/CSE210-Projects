using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 2));
        shapes.Add(new Rectangle("red", 5, 6));
        shapes.Add(new Circle("yello", 10));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}ft^2");
        }
    }
}
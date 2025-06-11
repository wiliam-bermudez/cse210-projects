using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("blue", 5.0);
        Rectangle rect1 = new Rectangle("White", 20.0, 5.0);
        Circle circ1 = new Circle("Green", 20.0);


        shapes.Add(square1);
        shapes.Add(rect1);
        shapes.Add(circ1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();

            Console.WriteLine($"Shape color: {shape.GetColor()} \n Area: {area}")
;        }
    }
}
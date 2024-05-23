using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("red", 3);

        shapes.Add(s1);

        Rectangle s2 = new Rectangle("orange", 4, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("yellow", 2);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            int count = 1;
            Console.WriteLine($"Figure:  {count}");
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }


    }
}
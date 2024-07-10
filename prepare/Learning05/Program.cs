using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 9);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Orange", 12, 8);
        shapes.Add(r1);

        Circle c1 = new Circle("Blue", 5);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"Thew {color} shape has an area of {area}");
        }
    }
}
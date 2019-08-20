using System;

public class Program
{
    public static void Main()
    {
        Shape sqr = new Square(5, 6);
        Shape rctangle = new Rectangle(5, 11);
        sqr.Draw();
        rctangle.Draw();
    }

}

abstract class Shape
{

    public readonly int X;
    public readonly int Y;

    public Shape(int x, int y)
    {
        this.X = x;
        this.Y = y;
        Console.WriteLine("in Shape class:");
    }

    public abstract void Draw();

}

class Square : Shape
{


    public Square(int x, int y) : base(x, y)
    {

    }

    public override void Draw()
    {
        Console.WriteLine("Square");
        Console.ReadKey();
    }
}
class Rectangle : Shape
{

    public Rectangle(int x, int y) : base(x, y)
    {
    }
    public override void Draw()
    {
        Console.WriteLine("Rectangle");
        Console.ReadKey();
    }
}
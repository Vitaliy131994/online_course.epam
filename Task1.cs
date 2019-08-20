using System;

public class Program
{
    public static void Main()
    {
        Shape sqr = new Square();
        Shape rctangle = new Rectangle();
        sqr.Draw();
        rctangle.Draw();
    }

}

abstract class Shape
{

    public abstract void Draw();

}

class Square : Shape
{

    public override void Draw()
    {
        Console.WriteLine("Square");
        Console.ReadKey();
    }
}
class Rectangle : Shape
{

    public override void Draw()
    {
        Console.WriteLine("Rectangle");
        Console.ReadKey();
    }
}
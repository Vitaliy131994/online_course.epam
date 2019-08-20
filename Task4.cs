using System;

public class Program
{
    public static void Main()
    {

        Shape shape = new Shape(6, 4);
        Shape sqr = new Square(5, 6);
        Shape rctangle = new Rectangle(5, 11);
        DrawAll(shape, sqr, rctangle);
    }

    public static void DrawAll(params IDrawable[] shapes)
    {
        foreach (IDrawable shape in shapes)
        {
            shape.Draw();
        }
    }

}

public interface IDrawable
{
    void Draw();


}
class Shape : IDrawable
{

    public readonly int X;
    public readonly int Y;

    public Shape(int x, int y)
    {
        this.X = x;
        this.Y = y;

    }

    public virtual void Draw()
    {

        Console.WriteLine("Shape drawing");
        Console.ReadKey();
    }

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

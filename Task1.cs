using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter X1");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y1");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X2");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y2");
        int y2 = int.Parse(Console.ReadLine());

        Point A = new Point(x1, y1);
        Point B = new Point(x2, y2);

        Rectangle r = new Rectangle(A, B);

        Console.WriteLine("Perum: " + r.Perum());
        Console.WriteLine("Square: " + r.square());
        Console.ReadLine();
    }

    class Rectangle
    {
        private Point A;
        private Point C;

        public Rectangle(Point A, Point C)
        {
            this.A = A;
            this.C = C;
        }

        public int Perum()
        {
            int ab = C.x - A.x;
            int bc = C.y - A.y;
            return (ab + bc) * 2;
        }

        public int square()
        {
            int ab = C.x - A.x;
            int bc = C.y - A.y;
            return ab * bc;
        }

    }

    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
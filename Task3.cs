using System;

public class Program
{
    
    public static void Main()
    {
        Console.WriteLine("Enter radius");
        int radius = int.Parse(Console.ReadLine());

        Circle C = new Circle(radius);

        Console.WriteLine("Length: " + C.Length());
        Console.WriteLine("Square: " + C.square());
        Console.ReadLine();
                
    }

    class Circle
    {
        const double PI = 3.14;
        private int radius;
            public Circle(int radius)
        {
            this.radius = radius;
          
        }

        public double Length()
        {
            return
                  2 * PI * radius;
        }

        public double square()
        {
            return
                PI * radius * radius;
        }

    }

}
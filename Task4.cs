using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Perum: " + Rectangle.Perum(A, B));
            Console.WriteLine("Square: " + Rectangle.square(A, B));
            Console.ReadLine();

            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());
                            
            Console.WriteLine("Length: " + Circle.Length(radius));
            Console.WriteLine("Square: " + Circle.square(radius));
            Console.ReadLine();

        }
    }
    class Rectangle
    {    

        public static int Perum(Point A, Point C)
        {
            int ab = C.x - A.x;
            int bc = C.y - A.y;
            return (ab + bc) * 2;
        }

        public static int square(Point A, Point C)
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
    class Circle
    {
        const double PI = 3.14;
       

        public static double Length(int radius)
        {
            return
                  2 * PI * radius;
        }

        public static double square(int radius)
        {
            return
                PI * radius * radius;
        }

    }
}

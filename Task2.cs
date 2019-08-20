namespace Task2
{
    class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int y2 = int.Parse(Console.ReadLine());
            Point Point1 = new Point(x1, y1);
            Point Point2 = new Point(x2, y2);
            Rectangle R = new Rectangle(Point1, Point2);
            Console.WriteLine("Perum:"+R.Perum());
            Console.WriteLine("Square:"+R.Square());
            Console.ReadKey();

        }
    }
    class Rectangle
    {
        Point a;
        public int ab {
            get { return c.x - a.x; }
        
        }
        Point c;
        public int bc
        {
            get { return c.y - a.y; }
        }
        public Rectangle(Point a1, Point c1) { a = a1;c = c1;  }
        public int Perum() {
            
            return (ab + bc) * 2; 
                }
        public int Square() {
              return (ab * bc);
        }
        }
    class Point
    {
        public Point(int x1, int y1) { x = x1;y = y1; } 
        public int x;
        public int y;
    }
}

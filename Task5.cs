using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Створення комплексних чисел і перемноження
            ComplexNumber R = new ComplexNumber(5, 6);
            ComplexNumber Z = new ComplexNumber(5, 6);
            Console.WriteLine("R*Z="+(R*Z).tostring());
            Console.ReadKey();
            #endregion

        }
    }
    class ComplexNumber
    {
        int x;
        int y;
        public ComplexNumber(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static ComplexNumber operator *(ComplexNumber A1, ComplexNumber A2)
        {
            return new ComplexNumber(((A1.x * A2.x) - (A1.y * A2.y)), ((A1.x * A2.y) + (A2.x * A1.y)));
            
        }
        public string tostring()
        {
            return x + "+i(" + y+")";
        }

    }
}

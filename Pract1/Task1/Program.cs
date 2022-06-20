using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1;
            double s2;

            Console.Write("enter 1st side of the rectangle: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter 2nd side of the rectangle: ");
            s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(s1, s2);

            Console.WriteLine("math area: " + myRectangle.Area);
            Console.WriteLine("perimeter: " + myRectangle.Perimeter);

            Console.ReadKey();
        }
    }
}

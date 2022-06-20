using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    static class TextPrinter
    {
        public static void Print(string str, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine(str, Console.ForegroundColor);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String enter: ");
            string str = Console.ReadLine();
            Console.Write("Choose colour (0 - white, 1 - red, 2 - green, 3 - blue): ");
            int color = Convert.ToInt32(Console.ReadLine());

            TextPrinter.Print(str, color);

            Console.ReadKey();
        }
    }
}

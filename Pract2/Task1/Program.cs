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
            Matrix matrix = new Matrix(2, 2);

            matrix.FeedMatrix();
            Console.WriteLine("Stolbov - {0}\nStrok - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            matrix.ShowMatrix();

            matrix.ChangeMatrix(4, 4);
            matrix.FeedMatrix();
            Console.WriteLine("Stolbov - {0}\nStrok - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            matrix.ShowMatrix();

            Console.ReadKey();
        }
    }
}

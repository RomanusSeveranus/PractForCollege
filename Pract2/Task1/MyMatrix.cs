using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        private int[,] matrix = null;

        private int numberOfCols;
        private int numberOfRows;

        public int NumberOfCols
        {
            get { return numberOfCols; }
        }
        public int NumberOfRows
        {
            get { return numberOfRows; }
        }

        public Matrix()
        {

        }

        public Matrix(int numberOfCols, int numberOfRows)
        {
            if (numberOfCols < 0 || numberOfRows < 0)
            {
                Console.WriteLine("Elements cant be negative");
            }
            else
            {
                this.numberOfCols = numberOfCols;
                this.numberOfRows = numberOfRows;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void ChangeMatrix(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Elements cant be negative");
            }
            else
            {
                this.numberOfCols = x;
                this.numberOfRows = y;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void FeedMatrix()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    Console.Write("Enter element: ");
                    matrix[i, j] = Convert.ToInt32 (Console.ReadLine());
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int col, int row]
        {
            set
            {
                if ((col > 0 && row > 0) && (col < numberOfCols && row < numberOfRows))
                    matrix[col, row] = value;
                else
                    Console.WriteLine("Wrong item indexes {0}:{1}", col, row);
            }
            get
            {
                return matrix[col, row];
            }
        }
    }
}

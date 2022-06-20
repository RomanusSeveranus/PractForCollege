using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        struct Train
        {
            public string point{ get; }
            public int num { get; }
            public string time { get; }

            public Train(string Point, int Num, string Time)
            {
                point = Point;
                num = Num;
                time = Time;
            }

            public void GetInfo()
            {
                Console.WriteLine("Train number: {0}\nWhere: {1}\nDeparture time: {2}", num, point, time);
            }
        }

        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Train {0}:", i + 1);
                Console.Write("Number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Where: ");
                string punkt = Console.ReadLine();
                Console.Write("Departure time: ");
                string time = Console.ReadLine();
                Console.WriteLine();

                trains[i] = new Train(punkt, n, time);
            }

          
            Train temp;
            for (int i = 0; i < trains.Length - 1; i++)
            {
                for (int j = i + 1; j < trains.Length; j++)
                {
                    if (trains[i].num > trains[j].num)
                    {
                        temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }

            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].GetInfo();
                Console.WriteLine();
            }

            Console.Write("Searching train:\nTrain number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].num == k)
                {
                    trains[i].GetInfo();
                }
            }

            Console.ReadKey();
        }
    }
}

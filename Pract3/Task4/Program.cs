using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public enum Pos
    {
        Junior = 140,
        Middle = 150,
        TeamLead = 160
    }

    public static class Accauntant
    {
        public static bool AskForBonus(Pos worker, int hours)
        {
            if (hours >= (int)worker)
                return true;
            else
                return false;
        }
    }

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.Write("Введите количество часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберете должность(1 - Junior; 2 - Middle; 3 - TeamLead): ");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine(Accauntant.AskForBonus(Pos.Junior, h));
                    break;
                case 2:
                    Console.WriteLine(Accauntant.AskForBonus(Pos.Middle, h));
                    break;
                case 3:
                    Console.WriteLine(Accauntant.AskForBonus(Pos.TeamLead, h));
                    break;

            }

            Console.ReadKey();
        }
    }
}

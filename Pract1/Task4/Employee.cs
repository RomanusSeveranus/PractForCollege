using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Employee
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Title { get; set; }
        private int Exp { get; set; }

        public Employee(string fn, string ln, string t, int exp)
        {
            FirstName = fn;
            LastName = ln;
            Title = t;
            Exp = exp;
        }

        public double Income()
        {
            double inc;
            switch (Title)
            {
                case "Junior":
                    inc = 70000;
                    break;
                case "Middle":
                    inc = 150000;
                    break;
                case "Team Lead":
                    inc = 300000;
                    break;
                default:
                    inc = 50000;
                    break;
            }
            inc = inc + inc / 100 * Exp;
            return Math.Round(inc, 2);
        }

        public double Tax() 
        {
            return Math.Round(Income() * 0.13, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine("first name: {0}\nlast name: {1}\nposition: {2}\nexpirience: {3}\nОincome: {4}\ntax: {5}", FirstName, LastName, Title, Exp, Income(), Tax());
        }
    }
}

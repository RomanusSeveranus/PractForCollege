using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first name: ");
            string fn = Console.ReadLine();
            Console.Write("last name: ");
            string ln = Console.ReadLine();
            Console.Write("position(Junior, Middle, Team Lead): ");
            string t = Console.ReadLine();
            Console.Write("job exp: ");
            int ex = Convert.ToInt32 (Console.ReadLine());
            Employee person1 = new Employee(fn, ln, t, ex);
            person1.GetInfo();
            Console.ReadKey();
        }
    }
}

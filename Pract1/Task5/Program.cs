using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Client: ");
            string client = Console.ReadLine();
            Console.Write("Supplier: ");
            string supp = Console.ReadLine();
            Console.Write("Count: ");
            int summ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item: ");
            string item = Console.ReadLine();
            Console.Write("Ammount: ");
            int k = Convert.ToInt32(Console.ReadLine());


            Invoice invoice = new Invoice(summ, client, supp, item, k);
            invoice.Show();

            Console.ReadKey();
        }
    }
}

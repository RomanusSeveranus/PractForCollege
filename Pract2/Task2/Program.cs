using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("Cup", "Fix Price", 100);
            Article a2 = new Article("Guitar", "Muzikalnyi", 5000);
            Article a3 = new Article("Laptop", "MVideo", 25000);

            Store store = new Store(new Article[] { a1, a2, a3 });

            Console.Write("Index search: ");
            store.GetArticle(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Name search: ");
            store.FindArticle(Console.ReadLine());

            Console.ReadKey();
        }
    }
}

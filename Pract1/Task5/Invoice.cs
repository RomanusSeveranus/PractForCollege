using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Invoice
    {
        public readonly int Account;
        public readonly string Customer; 
        public readonly string Supplier; 
        private string article; 
        private int quantity; 

        public Invoice(int account, string customer, string supplier, string article, int ammount) : this(account, customer, supplier)
        {
            article = article;
            ammount = quantity;
        }

        public Invoice(int account, string customer, string supplier)
        {
            Account = account;
            Customer = customer;
            Supplier = supplier;
        }

        public double GetAccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine("Client: {0}\nSupplier: {1}\nItem: {4} ({5})\nPrice without nds: {2}\nPrice with nds: {3}", Customer, Supplier, Account, GetAccountWithNds(), article, quantity);
        }
    }
}

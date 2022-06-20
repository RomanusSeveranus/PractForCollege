using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct MyStruct
    {
        public string Change { get; set; }
    }
    
    class MyClass
    {
        public string Change { get; set; }
    }

    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Changed";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change = "Changed";
        }

        static void Main(string[] args)
        {
            MyStruct s = new MyStruct();
            s.Change = "Not Changed";
            StruktTaker(s);
            Console.WriteLine(s.Change);

            MyClass c = new MyClass();
            c.Change = "Not Changed";
            ClassTaker(c);
            Console.WriteLine(c.Change);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_lesson11
{

    public abstract class customer
    {
        public abstract void Print();
    }




    class Program: customer
    {
        public override void Print()
        {
            Console.WriteLine("print method");

        }

        static void Main()
        {
            Program p = new Program();
            p.Print();

            customer c = new Program();
            c.Print();
        }
    }
}

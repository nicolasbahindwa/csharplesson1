using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackinCsharp
{
    class Program
    {
        static void Main()
        {
            customer c = new customer();
            {
                c.id = 1001;
                c.name = "nicole";
                c.gender = "female";

            };
            customer c2 = new customer();
            {
                c2.id = 1002;
                c2.name = "nicolas";
                c2.gender = "male";

            };
            customer c3 = new customer();
            {
                c3.id = 1003;
                c3.name = "james";
                c3.gender = "male";

            };

            Stack<customer> cst = new Stack<customer>();
            cst.Push(c);
            cst.Push(c2);
            cst.Push(c3);

            customer customers = cst.Pop();
            // pick the first item in the queue and keep in the queue
            customer customerspeek = cst.Peek();

            Console.WriteLine(customers.id + " " + customers.name + " " + customers.gender);
            Console.WriteLine("the total item in the stack is " + cst.Count());

            customer customers2 = cst.Pop();
            Console.WriteLine(customers2.id + " " + customers2.name + " " + customers2.gender);
            Console.WriteLine("the total item in the stack is " + cst.Count());

        }

    }

    public class customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueeCsharp
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

            Queue<customer> cst = new Queue<customer>();
            cst.Enqueue(c);
            cst.Enqueue(c2);
            cst.Enqueue(c3);

            // pick the first item in the queue and remove it from the queue.
            customer dq = cst.Dequeue();
            // pick the first item in the queue and keep in the queue
            customer peek1 = cst.Peek();
            Console.WriteLine(dq.id + " " + dq.name + " " + dq.gender);
            Console.WriteLine("the total item in the queue is " + cst.Count());

            customer dq1 = cst.Dequeue();
            Console.WriteLine(dq1.id + " " + dq1.name + " " + dq1.gender);
            Console.WriteLine("the total item in the queue is " + cst.Count());

        }
    }

    public class customer
    {
        public int id { get; set; }
        public string name  { get; set; }
        public string gender { get; set; }
    }
}

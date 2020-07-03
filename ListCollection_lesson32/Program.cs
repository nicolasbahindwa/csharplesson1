using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection_lesson32
{
    class Program
    {
        static void Main()
        {

            customer c = new customer();
            {
                c.ID = 100;
                c.name = "nicolas";
                c.salary = 40000;
            }

            customer c2 = new customer();
            {
                c2.ID = 101;
                c2.name = "jane";
                c2.salary = 400000;
            }
            customer c3 = new customer();
            {
                c3.ID = 100;
                c3.name = "rose";
                c3.salary = 30000;
            }

            List<customer> cust = new List<customer>(2);
            cust.Add(c);
            cust.Add(c2);
            cust.Add(c3);
        }
        public class customer
        {
            public int ID { get; set; }
            public string name { get; set; }
            public int salary { get; set; }

        }
    }
}

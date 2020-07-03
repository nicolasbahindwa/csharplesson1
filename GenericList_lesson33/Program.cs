using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_lesson33
{
    class Program
    {
        static void Main()
        {

            List<int> numbers = new List<int> {1,9,8,4,7,2,3,4,5,6,7,8,9};

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Sort();

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Reverse();

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            customer c = new customer();
            {
                c.custmerID = 100;
                c.name = "nicolas";
                c.salary = 40000;
                c.type = "retail";
            }

            customer c2 = new customer();
            {
                c2.custmerID = 101;
                c2.name = "jannet";
                c2.salary = 400000;
                c2.type = "cooroprate";
            }
            customer c3 = new customer();
            {
                c3.custmerID = 100;
                c3.name = "josehp";
                c3.salary = 30000;
                c3.type = "cooroprate";
            }
            customer c4 = new customer();
            {
                c4.custmerID = 100;
                c4.name = "greg";
                c4.salary = 30000;
                c4.type = "retail";
            }
            customer c5 = new customer();
            {
                c5.custmerID = 100;
                c5.name = "henry";
                c5.salary = 30000;
                c5.type = "cooroprate";
            }

            List<customer> cust = new List<customer>(2);
            cust.Add(c);
            cust.Add(c2);
            cust.Add(c3);
           
            List<customer> coorporatecustomer = new List<customer>(2);
            cust.Add(c4);
            cust.Add(c5);

            cust.AddRange(coorporatecustomer);
            cust.InsertRange(0,coorporatecustomer);
            cust.RemoveAll(x => x.type=="cooroprate");

            List<customer> customersList = cust.GetRange(2, 3);


            customersList.TrueForAll(x => x.salary > 4000);
        }



        
    }

    public class customer:IComparable<customer>
    {
        public int custmerID { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string type { get; set; }

        public int CompareTo(customer other)
        {
            //if (this.salary > other.salary)
            //    return 1;
            //else if (this.salary < other.salary)
            //    return 1;
            //else
            //    return 0;
            return this.salary.CompareTo(other.salary);
        }
    }
}

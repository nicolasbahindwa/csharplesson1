using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Dictionary_lesson31
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

            Dictionary<int, customer> customerDisctionary = new Dictionary<int, customer>();
           
            customerDisctionary.Add(c2.ID, c2);
            customerDisctionary.Add(c3.ID, c3);
            if (customerDisctionary.ContainsKey(c.ID))
            {
                customerDisctionary.Add(c.ID, c);
            }

            customer cst = customerDisctionary[101];
            foreach (KeyValuePair<int, customer> customerKeyValuePair in customerDisctionary)
            {
                Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
                customer cs = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0} name ={1} salary {2}", cs.ID, cs.name, cs.name);
                Console.WriteLine("-----------------------------------------");
            }



            Console.WriteLine("ID={0} name {1}  salary{3}", cst.ID,cst.name,cst.salary); 
        }
    }

    public class customer
    { 
     public int ID { get; set; }
    public string name { get; set; }
    public int salary { get; set; }

    }
}

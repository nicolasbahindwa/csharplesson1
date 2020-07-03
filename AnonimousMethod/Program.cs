using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimousMethod
{
    class Program
    {
       public static void Main()
        {
            List<employee> emplist = new List<employee>()
            {
             new employee{ id=100, name="nicolas"},
             new employee{ id=101, name="joseline"}
            };

            //  Predicate<employee> employeepred = new Predicate<employee>(findEmp);
            //  employee searchR = emplist.Find(e => employeepred(e));
            employee empl = emplist.Find(
                delegate (employee lst) {
                    return lst.id == 101;
                });
            Console.WriteLine(empl.id + " " + empl.name);
                
                
        }

        public static bool findEmp(employee empl)
        {
            return empl.id == 101;
        }
    }
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}

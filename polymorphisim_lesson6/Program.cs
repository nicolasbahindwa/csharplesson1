using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisim_lesson6
{
    class Program
    {
        static void Main()
        {
            employee[] employees = new employee[4];

            employees[0] = new employee();
            employees[1] = new partimeEmployee();
            employees[2] = new fullTimeEmployee();
            employees[3] = new temporaryTimeEmployee();

            foreach (employee emp in employees)
            {
                emp.printEmployee();
            }
        }
    }
    public class employee
    {
        public string fname = "nicolas";
        public string lname = "bahindwa";

        public virtual void printEmployee()
        {
            Console.WriteLine(fname + "" + lname);
        }
    }

    public class partimeEmployee : employee
    {
        public override void printEmployee()
        {
            Console.WriteLine(fname + " " + lname + "partime");
        }
    }
    public class fullTimeEmployee : employee
    {
        public override void printEmployee()
        {
            Console.WriteLine(fname + " " + lname + "fulltime");
        }
    }
    public class temporaryTimeEmployee : employee
    {
        public override void printEmployee()
        {
            Console.WriteLine(fname + "" + lname + " temporary");
        }
    }
}

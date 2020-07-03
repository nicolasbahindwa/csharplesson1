using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodhidding_lesson5
{
    class Program
    {
        static void Main()
        {
            fullTimeEmployee FTE = new fullTimeEmployee();
            FTE.fname = "nicolas";
            FTE.lname = "bahindwa";
            FTE.printEmployee();

            fullTimeEmployee PTE = new fullTimeEmployee();
            PTE.fname = "mukomezi";
            PTE.lname = "bahindwa";
            ((employee)PTE).printEmployee();

            employee PTE_ = new fullTimeEmployee();
            PTE_.fname = "mukomezi";
            PTE_.lname = "bahindwa";
            ((employee)PTE_).printEmployee();
        }
    }
    public class employee
    {
        public string fname;
        public string lname;

        public void printEmployee()
        {
            Console.WriteLine(fname + "" + lname);
        }
    }

    public class partimeEmployee:employee
    {
        // method hidding 
        public new void printEmployee()
        {
            base.printEmployee();
          //  Console.WriteLine(fname + "" + lname + "contractor");
        }

    }
    public class fullTimeEmployee:employee
    { 
    
    }
}

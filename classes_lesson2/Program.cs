using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_lesson2
{
    class Program
    {
        static void Main()
        {
            customer c1 = new customer("nicolas", "bahindwa");
            c1.printFullname();

            customer c2 = new customer();
            c2.printFullname();
        }
    }

    class customer
    {
        string _fname;
        string _lname;
        public customer(string fname, string lname)
        {
            //this._fname = fname;
            //this._lname = lname;
            _fname = fname;
            _lname = lname;
        }
        public customer()
            : this("no fname provided", "no last name provided")
        {
        }
        public void printFullname()
        {
            Console.WriteLine("full name is {0}", _fname + " " + _lname);
        }
    }
}

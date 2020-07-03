using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOverride_lesson26
{
    class Program
    {
        static void Main()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            customer C = new customer();
            C.Lname = "NICOLAS";
            C.Fname = "BAHINDWA";
            Console.WriteLine(Convert.ToString(C));
        }
    }

    public class customer
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

        public override string ToString()
        {
            return Fname + " " + Lname;
        }

    }
}

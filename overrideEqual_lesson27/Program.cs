using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideEqual_lesson27
{
    class Program
    {
       public static void Main()
        {
            //Direction newDirection = Direction.east;
            //Direction newDirection2 = Direction.east;

            //Console.WriteLine(newDirection.Equals(newDirection2));

            //int j = 10;
            //int i = 10;

            customer c = new customer();
            c.fname = "nicolas";
            c.lname = "nicolas";
            Console.WriteLine(c.fname.Equals(c.lname));

        }
    }

    public enum Direction
    {
     north,
     south,
     west,
     east
    }

    public class customer
    {
        public string fname { get; set; }
        public string lname { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is customer))
            {

                return false;
            }
            return this.fname == ((customer)obj).fname &&
                this.lname == ((customer)obj).lname;
        }

        public override int GetHashCode()
        {
            return this.fname.GetHashCode() ^ this.lname.GetHashCode();
        }
    }





}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main()
        {

        }

        public void Add(int fn, int sn)
        {
            Console.WriteLine("sumis {0}", fn + sn);
        }

        public void Add(float fn, float sn)
        {
            Console.WriteLine("sumis {0}", fn + sn);
        }
    }

   

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using AccessModifier_lesson_19;

namespace AccessModifier2
{
    class Program
    {
        static void Main()
        {

        }
    }

    public class bonus:customer
    {
        public void print()
        {
            //customer c = new customer();
            //c.
            base.ID = 100;

            bonus b = new bonus();
            b.ID = 100;

        }
    
    }


}

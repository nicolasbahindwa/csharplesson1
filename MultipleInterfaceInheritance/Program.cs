using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceInheritance
{
   
    public class A:IA
    {
        public void Amethod()
        {
            Console.WriteLine("A");
        }
    }
    public class B:IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B");
        }

    }

    interface IA
    {
        void Amethod();
    }
    interface IB
    {
        void Bmethod();
    }

    public class AB:IA,IB
    {
        A a = new A();
        B b = new B();

        public void Amethod()
        {
            a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }

    }
    class Program
    {

        static void Main()
        {
            AB x = new AB();
            x.Bmethod();
            x.Bmethod();
        }
    }


}

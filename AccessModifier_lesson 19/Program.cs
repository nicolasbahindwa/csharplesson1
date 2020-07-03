using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_lesson_19
{
    class Program
    {
        static void Main()
        {

        }
    }


    public class customer
    {
        protected int ID;
       protected internal int _id; 

        //private int _id;
        //public int ID
        //{
        //    get { return ID; }
        //    set { _id = value; }
        //}
    
    }

    public class Sales:customer
    {
        public void Print()
        {
            Sales c = new Sales();
            c.ID = 1;
            base.ID = 100;
            this.ID = 500;
        }
        
    
    }
}

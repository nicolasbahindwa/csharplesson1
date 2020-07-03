using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_lesson10
{
    //interface Icustomer
    //{
    //    void Print();
    //}
    //interface I2
    //{
    //    void I2Method();
    //}
    //public class Customer : Icustomer, I2
    //{
    //    public void I2Method()
    //    {
    //        Console.WriteLine(" I2 interface print method");
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("interface print method");
    //    }
    //}

    interface Icustomer1
    {
        void Print();
    }

    //interface Icustomer2:Icustomer1
    //{
    //    void Print();
    //}

    interface Icustomer2
    {
        void Print();
    }
    public class Customer : Icustomer2
    {
        public void Print()
        { 
        
        }

        //public void Print2()
        //{

        //}
    }

    // explicit interface implementation
    public class customer2:Icustomer1,Icustomer2
    {
        void Icustomer1.Print()
        {
            Console.WriteLine("i method print");
        }

        void Icustomer2.Print()
        {
            Console.WriteLine("i method print");
        }
    }


    class Program
    {
        static void Main()
        {
            Customer c = new Customer();
            c.Print();

            //Icustomer1 cust = new Customer();
            //cust.Print();
        }
    }
}

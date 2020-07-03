using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OptionalParameter_lesson31
{
    class Program
    {
        static void Main()
        {

           // addNumber(10, 20,new object[] { 30,40,50});
            //addNumber(10, 20,null);
           // addNumber(10, 20);
            addNumber(10, 20, new int[] { 30,40});
            test(1,2, c: 20);
        }

        public static void test(int a, int b, int c = 20)
        {
            Console.WriteLine("a = ", a);
            Console.WriteLine("b = ", b);
            Console.WriteLine("c = ", c);
        }
        public static void addNumber(int fnumber, int lnumber,[OptionalAttribute] int[] restofNumber)
        {
            int result = fnumber + lnumber;
            if (restofNumber != null)
            {
                foreach (int i in restofNumber)
                    result += i;
            }

            Console.WriteLine("the result is =" + result);
        }

        //public static void addNumber(int fnumber, int lnumber)
        //{
        //   // int result = fnumber + lnumber;
        //    addNumber(fnumber, lnumber, null);
        //}

        //public static void addNumber(int fnumber, int lnumber, int[] restofNumber)
        //{
        //    int result = fnumber + lnumber;
        //    if (restofNumber != null)
        //    {
        //        foreach (int i in restofNumber)
        //            result += i;
        //    }

        //    Console.WriteLine("the result is =" + result);
        //}

        //public static void addNumber(int fnumber, int lnumber,params object[] restofNumber)
        //{
        //    int result = fnumber + lnumber;
        //    if (restofNumber != null)
        //    {
        //        foreach(int i in restofNumber)
        //        result += i;
        //    }

        //    Console.WriteLine("the result is =" + result);
        //}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAbuse_lesson16
{
    class Program
    {
        static void Main()
        {
            try
            {
                int Numerator;
                bool isnumeratorConversionSuccess = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (isnumeratorConversionSuccess)
                {
                    int Denominator;
                    bool isDenominatorConversionSuccess = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (isDenominatorConversionSuccess && Denominator != 0)
                    {
                        int c = Numerator / Denominator;
                        Console.WriteLine("the a/b is {0}", c);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator can not be zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number");

                        }

                    }

                }
                else
                {
                    Console.WriteLine("only number between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception)
            { 
            
            }

            //try
            //{
            //    Console.WriteLine("please enter the first number");
            //    int a = int.Parse(Console.ReadLine());

            //    Console.WriteLine("please enter the first number");
            //    int b = int.Parse(Console.ReadLine());

            //    int c = a / b;
            //    Console.WriteLine("the a/b is {0}", c);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("only nember are allowed");

            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("only number between {0} and {1} are allowed", Int32.MaxValue, Int32.MinValue);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine();
            //}
          
        }
    }
}

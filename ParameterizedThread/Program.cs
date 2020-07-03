using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedThread
{
    public delegate void SumofNumberCallBack(int sumofNumbers);

    class Program
    {

        public static void PrintSum(int sum)
        {
            Console.WriteLine(sum);
        }
        static void Main()
         {
           

            Console.WriteLine("please enter the target");
            int target = Convert.ToInt32(Console.ReadLine());

            SumofNumberCallBack callback = new SumofNumberCallBack(PrintSum);
            //Number n = new Number();
            // Number n = new Number(target);
            Number n = new Number(target, callback);
            //  ParameterizedThreadStart param = new ParameterizedThreadStart(n.PrintNumber);
            //Thread T = new Thread(param);
            Thread T = new Thread(new ThreadStart(n.PrintSumOfNumber));
            T.Start();

        }
    }
    public class Number
    {
        private int _target;
        SumofNumberCallBack _callBackMethod;
            public Number(int target, SumofNumberCallBack callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }


        public void PrintSumOfNumber()
        {
            int sum=0;
            for (int i = 0; i <= _target; i++)
            {
                sum = sum + i;
                //Console.WriteLine(i);
            }
            if (_callBackMethod != null)
            {
                _callBackMethod(sum);
            }
        }
        //public void PrintNumber()
        //{
        //    //int number;
        //    //if (int.TryParse(target.ToString(), out number))
        //    //{
        //    //    for (int i = 0; i <= number; i++)
        //    //    {
        //    //        Console.WriteLine(i);
        //    //    }
        //    //}

        //    for (int i = 0; i <= _target; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}

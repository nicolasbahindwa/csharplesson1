using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innnerExxception_lesson14
{
    class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("please enter the first number");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("please enter the first number");
                    int b = int.Parse(Console.ReadLine());

                    int c = a / b;
                    Console.WriteLine("the a/b is {0}", c);


                }
                catch (Exception ex)
                {
                    string filepath = @"C:\fileprojectTest\log1.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("something went wrong try again later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "file not found", ex);

                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("the exception is = {0}", e.GetType().Name);
                if(e.InnerException !=null)
                {
                    Console.WriteLine("the inner exception is ={0}", e.InnerException.GetType().Name);

                }


            }

          


                       

        }
    }
}

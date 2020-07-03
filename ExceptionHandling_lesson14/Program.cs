using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling_lesson14
{
    class Program
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\fileprojectTest\file.txt");
                Console.WriteLine(streamReader.ReadToEnd());
              
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    streamReader.Close();
            //}
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("stream to be closed");

        }
    }
}

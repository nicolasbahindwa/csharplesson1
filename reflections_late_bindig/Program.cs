using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflections_late_bindig
{
    class Program
    {
       public static void Main()
        {
            Assembly ExcecutiveAssembly = Assembly.GetExecutingAssembly();
            Type customerType = ExcecutiveAssembly.GetType("reflections_late_bindig.customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Nicolas";
            parameters[1] = "Bahindwa";

           string FullName = (string)getFullNameMethod.Invoke(customerType, parameters);

            Console.WriteLine("full name is {0}", FullName);

        }
    }

    public class customer
    {
        public string GetFullName(string fname, string lname)
        {
            return fname + " " + lname;
        }
    }
}

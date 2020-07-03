using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections_lesson21
{
    class Program
    {
        static void Main()
        {
            //Type T = Type.GetType("Reflections_lesson21.customer");

            Type T = typeof(customer);
            Console.WriteLine("full name is ={0}",T.FullName);
            Console.WriteLine("just name is ={0}", T.Name);
            Console.WriteLine("full name is ={0}", T.FullName);

            Console.WriteLine();
            Console.WriteLine("properties in customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();
            Console.WriteLine("methodof customer class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }

            Console.WriteLine();
            Console.WriteLine("constructors customer class");
            ConstructorInfo[] contructor = T.GetConstructors();
            foreach(ConstructorInfo constr in contructor)
            {
                Console.WriteLine(constr.Name + " " + constr.MemberType);
            }
        }
    }

    public class customer
    {

        public int id { get; set; }
        public string name { get; set; }

        public customer(int ID, string Name)
        {
            this.id = ID;
            this.name = Name;
        }
        public customer()
        {
            this.id = 1;
            this.name = string.Empty;
        }

    }
}

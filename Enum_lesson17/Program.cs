using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_lesson17
{
    class Program
    {
    public  static void Main()
        {
            custmer[] mycustomer = new custmer[3];


            mycustomer[0] = new custmer
            {
                name = "nicolas",
                gender = gender.male,
            };
            mycustomer[1] = new custmer
            {
                name = "jane",
                gender = gender.male,
            };
            mycustomer[2] = new custmer
            {
                name = "todd",
                gender = gender.Unknow,
            };

 

            foreach (custmer cst in mycustomer)
            {
                Console.WriteLine("name is : {0} and gender is {1}", cst.name, cst.gender);

            }
        }

        public static string GetGender(gender Gender)
        {
            switch (Gender)
            {
                case gender.Unknow:
                    return "Unknown";
                case gender.male:
                    return "Male";
                case gender.female:
                    return "female";
                default:
                    return "invalid data";
            }
        }
    }

    
    public enum gender
    { 
        Unknow,
        male,
        female
    }
    public class custmer
    {
        public string name { get; set; }
        public gender gender { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelesson4
{
    class Program
    {
        static void Main()
        {
            FulltimeEmployee FTA = new FulltimeEmployee();
            FTA.firstname = "nicolas";
            FTA.lastname = "bahindwa";
            FTA.yearlySalary = 500000;
            FTA.printEmployee();

            PartimeEmplyee PTA = new PartimeEmplyee();
            PTA.firstname = "mukomezi";
            PTA.lastname = "bahindwa";
            PTA.hourlySalary = 10000;
            PTA.printEmployee();
        }

        
    }

    public class employee
    {
        public string firstname;
        public string lastname;
        public string email;

        public void printEmployee()
        { 
        
        }
    
    }
    public class FulltimeEmployee:employee
    {
        public float yearlySalary;
    }
    public class PartimeEmplyee : employee
    {
        public float hourlySalary;
    }

    // using Base keeword

    public class parentclass
    {
        public parentclass()
        {
            Console.WriteLine("parameterless constractor called");
        }
        public parentclass(string message)
        { 
        
        }
    
    }
    public class childClass : parentclass
    {
        public childClass():base("derived class controlling parent class")
        {
            Console.WriteLine("child class constractor called");
        }


    }
}

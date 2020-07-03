using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePart2_lesson12
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() {ID= 100, name="nicolas", salary=100000, experiece=5 });
            employees.Add(new Employee() { ID = 101, name = "james", salary = 400000, experiece = 15 });
            employees.Add(new Employee() { ID = 102, name = "chrispin", salary = 500000, experiece = 3 });
            employees.Add(new Employee() { ID = 103, name = "derick", salary = 600000, experiece = 6 });

            IsPromoded isPromotable = new IsPromoded(promote);

            Employee.promoted(employees, isPromotable);
        }

        public static bool promote(Employee emp)
        {
            if (emp.experiece > 5)
            {
                return true;
            }
            else {
                return false;
            }



        }
    }

  public  delegate bool IsPromoded(Employee employee);

    public class Employee
    {

        public int ID { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int experiece { get; set; }

        public static void promoted(List<Employee> employee, IsPromoded IsEligibleToPromote)
        {
            foreach (Employee emp in employee)
            {
                if (IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.name + " promoted");
                }
            }
        }
       
    }
}

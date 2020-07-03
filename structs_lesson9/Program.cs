using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs_lesson9
{
    class Program
    {
        static void Main()
        {
            Customer c = new Customer()
            {
                ID = 101,
                Name = "NICOLAS"

            };
            c.printCustomer();

        }

       
    }

    public struct Customer
    {
        private int _id;
        private string name;

        public int ID
        {
            get
            {

                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Name
        {
            get
            {

                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Customer(int ID, string Name)
        {
            this._id = ID;
            this.name = Name;
        }

        public void printCustomer()
        {

            Console.WriteLine("id = {0} , name = {1}", this._id, this.name);
        }
    }
}

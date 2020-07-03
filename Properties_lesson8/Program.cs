using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_lesson8
{
    public class student
    {
        public int ID;
        public string name;
        public int passMark = 35;

        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("student ID can not be negative");
            }
            this.ID = id;
        }
        public int GetID()
        {
            return this.ID;
        }


        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("name can not be empty");
            }
            this.name = name;
        }
        public string Getname()
        {
            return (string.IsNullOrEmpty(this.name)) ? "no name" : this.name;

            //if (string.IsNullOrEmpty(this.name))
            //{
            //    return this.name = "no name";
            //}
            //else
            //{
            //    return this.name;
            //}

        }

        public int GetPassMark()
        {
            return this.passMark;
        }


        public int id
        {
            set {
                if (value <= 0)
                {
                    throw new Exception("student ID can not be negative");
                }
                this.ID = id;
            }

            get {

                return this.id;
            }
        
        }

        public int mark
        {
            get {
                return this.mark;
            }
        }



    }
   public class Program
    {
        public static void Main()
        {
            student c = new student();
            c.SetId(2);
            c.id = 100;
            c.SetName("nicolas");
            c.GetPassMark();

           // Console.WriteLine("student is id {0}, name {1} , passmark{2}", c.GetID(),c.Getname(), c.GetPassMark());
            Console.WriteLine("student is id {0}, mark {1} ", c.id, c.mark);

            // c.SetId(-100);
        }
    }
}

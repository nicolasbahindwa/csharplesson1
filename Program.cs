using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
//using ProjectA.TeamA;
//using ProjectA.TeamB;
//using Project_teamA = ProjectA.TeamA;
//using Project_teamB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;

namespace csharplesson1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        static void Main()
        {
            // lesson1();
            //lesson2();
            // nullableoperator();
            // arrays();
            // SwitchCase();
            //  SwitchCase2();
            //  whileloops();
            //foreachStatements();

            //Program p = new Program();
            //p.Methods();
            //Program.Methods();

            //int j = 0;
            //simplemethod(ref j);
            //Console.WriteLine(j);

            //    int total = 0;
            //    int product = 0;
            //    calculate(10, 20, out total, out product);
            //    Console.WriteLine("total is {0} and product is {1}", total, product);

            //int[] numbers = new int[3];
            //numbers[0] = 100;
            //numbers[1] = 101;
            //numbers[2] = 102;
            //parameterArrays(numbers);

            //ProjectA.TeamA.ClassA.Print();
          // Project_teamA.ClassA.Print();
            // ProjectA.TeamB.ClassA.Print();
          //  Project_teamB.ClassA.Print();
        }

        static void lesson1()
        {
            Console.WriteLine("please type your name");
            string username = Console.ReadLine();

            Console.WriteLine("please type your last name");
            string lastname = Console.ReadLine();

            //   Console.WriteLine("your name is :" + username);
            Console.WriteLine("your name is {0} {1}", username, lastname);
            // read article refer to esape characters in c#


            Console.WriteLine("one\ntwo\nthree");

            Console.WriteLine("\"welcome\"");

            Console.WriteLine("c:\\users\\data\\csharp1");
            Console.WriteLine(@"c:\\users\\data\\csharp1");
        }

        static void lesson2()
        {

            int number = 10;
            //bool isnumber10;
            bool isnumber10 = number == 10 ? true : false;
            //if (number == 10)
            //{
            //    isnumber10 = true;
            //}
            //else
            //{
            //    isnumber10 = false;
            //}


            Console.WriteLine("isnumber10 == 10 is {0}", isnumber10);
        }

        static void nullableoperator()
        {

            //bool? ismajor = null;

            //if(ismajor == true)
            //{
            //    Console.WriteLine("user is major");
            //}
            //else if(ismajor == false)
            //{
            //    Console.WriteLine("user is not a manjor"); 

            //}
            //else
            //{
            //    Console.WriteLine("the user didn't answer the question");

            //}

            //int? tickets = null;
            //int avalaibleticket;

            //if(tickets==null)
            //{
            //    avalaibleticket = 0;
            //}
            //else
            //{
            //    avalaibleticket =(int) tickets;
            //}

            //null colasing operator

            int? ticket = 100;
            int avalaibleticket = ticket ?? 0;

            Console.WriteLine("available ticket is {0}", avalaibleticket);
        }

        static void DatatypeConversion()
        {

            float f = 123.234f;
            // type cast conversion
            // int i = (int)f;
            int i = Convert.ToInt32(f);

            string number = "100";
            int a = int.Parse(number);


            string numeric = "100gt";
            int b = 0;

            int.TryParse(numeric, out b);
            Console.WriteLine(b);
        }

        static void arrays()
        {
            int[] numbers = { 1, 2, 3 };

            int[] number = new int[3];
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            Console.WriteLine(number[1]);


        }

        static void SwitchCase()
        {
            Console.WriteLine("please enter a number");
            int number = int.Parse(Console.ReadLine());

            //if (number == 10)
            //{
            //    Console.WriteLine("number is {0}", number);
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("number is {0}", number);
            //}
            //else
            //{
            //    Console.WriteLine("number is not 10 or 20");
            //}

            switch (number)
            {

                case 10:
                    Console.WriteLine("number is {0}", number);
                    break;
                case 20:
                    Console.WriteLine("number is {0}", number);
                    break;
                default:
                    Console.WriteLine("number is not 20 or 10");
                    break;
            }

        }

        static void SwitchCase2()
        {
            int totalCofeeCost = 0;
            Console.WriteLine("1. small, 2. middium, 3. large");
            int userchoice = int.Parse(Console.ReadLine());
        Start:
            switch (userchoice)
            {
                case 1:
                    totalCofeeCost += 1;
                    break;
                case 2:
                    totalCofeeCost += 2;
                    break;
                case 3:
                    totalCofeeCost += 3;
                    // jumper to another case statement
                    // goto case 1;
                    break;

                default:
                    Console.WriteLine("your choice is not available");
                    goto Start;

            }
        //label
        Decide:
            Console.WriteLine("do you want to buy another cofee YES or No");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice isivalid");
                    goto Decide;
            }
            Console.WriteLine("thanks for shopping with us");
            Console.WriteLine("the total bill is {0}", totalCofeeCost);
        }

        static void whileloops()
        {
            string yourChoice = string.Empty;
            do
            {

                Console.WriteLine("please enter your targeet");
                int target = int.Parse(Console.ReadLine());
                int userstart = 0;
                while (userstart <= target)
                {
                    Console.WriteLine(target);
                    Console.Write(target + " ");
                    userstart = userstart + 2;
                }



                do
                {
                    Console.WriteLine("do you want to cotinu YES or No");
                    yourChoice = Console.ReadLine().ToLower();
                    if (yourChoice != "yes" && yourChoice != "no")
                    {
                        Console.WriteLine("invalid choice please say yes or no");
                    }
                }
                while (yourChoice != "yes" && yourChoice != "no");
            } while (yourChoice == "yes");

        }
        static void foreachStatements()
        {
            //int[] number = new int[3];
            //number[0] = 100;
            //number[1] = 101;
            //number[2] = 103;

            //foreach (int a in number)
            //{
            //    Console.WriteLine(a);
            //}

            //for(int j=0;j< number.Length; j++)
            //{

            //    Console.WriteLine(number[j]);
            //}
            //int i = 0;
            //while (i < number.Length)
            //{

            //    Console.WriteLine(number[i]);
            //    i++;
            //}

            //for (int i = 1; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i ==10)
            //    {
            //        break;
            //    }
            //}

            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);

            }


        }

        public static void Methods()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }

         }

        //public static void simplemethod(ref int j)
        //{
        //    j = 102;
        //}

        public static void calculate(int FN, int SN, out int sum, out int diffrence)
        {
            sum = FN + SN;
            diffrence = FN / SN;
        }

        public static void parameterArrays(params int[] numbers)
        {

            Console.WriteLine( " the are {0} in the array",numbers.Length);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

         
    }
}


//namespace ProjectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("team a class");
//            }
//        }
    
//    }

//}

//namespace ProjectA
//{
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("team b class");
//            }
//        }

//    }

//}


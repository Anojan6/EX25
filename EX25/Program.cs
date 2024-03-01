using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the firts integer : ");
            int FirstNumb = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer : ");
            int SecondNumb = int.Parse(Console.ReadLine());

            Console.WriteLine("1- Addition \n2- Subtraction \n3- Multiplication \n4- Division \n5- Exit ");
            Console.WriteLine("Here are the operation ");

            Console.WriteLine("Input your choice : ");
            string Operation = Console.ReadLine();


            Calculator(Operation, FirstNumb, SecondNumb);   
            Console.ReadLine();
        }


        public static void Calculator (string oparation, int FirstNumb , int SecondNumb)
        {
            int tot;
            switch (oparation)
            {
                case "1":
                    tot = FirstNumb+SecondNumb;
                    Console.WriteLine("The Addition of {0} and {1} is : {2} ", FirstNumb,SecondNumb,tot);
                    break;
                case "2":
                    tot = FirstNumb-SecondNumb;
                    Console.WriteLine("The Subtraction of {0} and {1} is : {2} ", FirstNumb, SecondNumb, tot);
                    break;
                case "3":
                    tot = FirstNumb*SecondNumb;
                    Console.WriteLine("The Multipilication of {0} and {1} is : {2} ", FirstNumb, SecondNumb, tot);
                    break;
                case "4":
                    if (SecondNumb != 0)
                    {
                        tot = FirstNumb / SecondNumb;
                        Console.WriteLine("The Division of {0} and {1} is : {2} ", FirstNumb, SecondNumb, tot);
                    }
                    else
                    {
                        Console.WriteLine("Invalid cant divide by zero ");
                    }
                    break;
                default:
                    Console.WriteLine("");
                    break;
//bhfrvghdfbvhdf







            }
        }
    }
}

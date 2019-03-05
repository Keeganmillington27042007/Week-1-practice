using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter either 1, 2 or 3");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("You have chosen Number 1");
            }
            else if (input == 2)
            {
                Console.WriteLine("You have chosen Number 2");
            }
            else if (input == 3)
            {
                Console.WriteLine("You have chosen Number 3");  
            }
            else
            {
                Console.WriteLine("Wrong number entered, please try again");
            }
            Console.WriteLine("Would you like to perform a *, /, + or - equation");
            string Uinput = (Console.ReadLine());

            if (Uinput == "*")
            {
                Console.WriteLine("You have chosen Multiplication");
            }
            else if (Uinput == "/")
            {
                Console.WriteLine("You have chosen division");
            }
            else if (Uinput == "+")
            {
                Console.WriteLine("You have chosen addition");
            }
            else if (Uinput == "-")
            {
                Console.WriteLine("You have chosen subtraction");
            }
            else
            {
                Console.WriteLine("Wrong key entered");
            }

            Console.ReadKey();
        }
    }
}

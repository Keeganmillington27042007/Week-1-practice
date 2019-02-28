using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your email address: ");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter a 4 digit pin: ");
            int pin = int.Parse(Console.ReadLine());
            Console.ReadKey();

        }
    }
}

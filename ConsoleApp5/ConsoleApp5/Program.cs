using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your first name: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("Whats your last name: ");
            string Lname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}, how is your day going?",Fname,Lname);
            Console.ReadKey();
        }
    }
}

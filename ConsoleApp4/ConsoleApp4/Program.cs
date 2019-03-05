using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            int Fnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            int Snum = int.Parse(Console.ReadLine());

            double Total = Fnum + Snum;
            Console.WriteLine("\n {0} + {1} = {2}", Fnum, Snum, Total);
            double total = Fnum - Snum;
            Console.WriteLine("\n {0} - {1} = {2}", Fnum, Snum, total);
            double times = Fnum * Snum;
            Console.WriteLine("\n {0} * {1} = {2}", Fnum, Snum, times);
            double devide = Fnum / Snum;
            Console.WriteLine("\n {0} / {1} = {2}", Fnum, Snum, devide);
            Console.ReadKey();
        }
    }
}

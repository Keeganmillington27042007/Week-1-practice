using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first whole number: ");
            int Fnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second whole number: ");
            int Snum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your first decimal point number: ");
            double dec1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second decimal point number: ");
            double dec2 = double.Parse(Console.ReadLine());
            Console.WriteLine("First whole number is {0}, Second whole number is {1}", Fnum, Snum);
            Console.WriteLine("First decimal point number is {0}, Second decimal point number is {1}", dec1, dec2);
            int Total = Fnum + Snum;
            Console.WriteLine("\nwhole number {0} + whole number {1} = {2}",Fnum,Snum,Total);
            double Dtotal = dec1 + dec2;
            Console.WriteLine("\nwhole number {0} + whole number {1} = {2}", dec1, dec2, Dtotal);
            Console.ReadKey();
        }
    }
}

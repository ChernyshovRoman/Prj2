using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {

        static double F(double x)
        {
            return 8 * Math.Sin(2*x)-Math.Cos(2*x);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double y = F(x);
            Console.WriteLine("8 * Math.Sin(2*x)-Math.Cos(2*x) ="+y);
            Console.ReadLine();
        }
    }
}
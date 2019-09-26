using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic operations on integers:");

            int x = 4;
            int y = 6;

            int add = x + y;
            int subtract = y - x;
            int multiply = x * y;

            Console.WriteLine("x + y =" + " " + add);
            Console.WriteLine("y - x =" + " " + subtract);
            Console.WriteLine("x * y =" + " " + multiply);

            // okno pozostaje otwarte; zamyka okno po naciśnięciu Enter
            // Console.ReadLine();

            // okno pozostaje otwarte; zamyka okno po naciśnięciu jakiegokolwiek przycisku
            Console.ReadKey();
        }
    }
}

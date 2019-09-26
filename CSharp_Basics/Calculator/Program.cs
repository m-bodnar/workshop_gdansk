using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MathData mathData = GetInformationFromUser.GetAllValuesFromCustromer();
                
                double result = Calculations.DoMath(mathData);

                Console.WriteLine("Wynik to:" + " " + result);
            }                
        }
    }
}

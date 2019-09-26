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
        static bool quit = false;

        static void Main(string[] args)
        {
            while (!quit)
            {
                MathData mathData = new MathData();

                mathData.firstNumber = GetInformationFromUser.GetValueFromUser("Podaj wartosc liczby A");

                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    return;
                }

                mathData.secondNumber = GetInformationFromUser.GetValueFromUser("Podaj wartosc liczby B");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    return;
                }

                double result = 0;

                mathData.Operation = GetInformationFromUser.GetOperationFromUser();
                
                result = Calculations.DoMath(mathData);

                Console.WriteLine("Wynik to:" + " " + result);
            }                
        }
    }
}

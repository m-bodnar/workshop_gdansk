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
            
            // bool isRunning = true;
            while (!quit)
            {
                
                int parseA = GetInformationFromUser.GetValueFromUser("Podaj wartosc liczby A");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    return;
                }

                int parseB = GetInformationFromUser.GetValueFromUser("Podaj wartosc liczby B");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    return;
                }

                double result = 0;

                string operationSign = GetInformationFromUser.GetOperationFromUser();
                
                result = Calculations.DoMath(operationSign, parseA, parseB);


                Console.WriteLine("Wynik to:" + " " + result);
            }                
        }
    }
}

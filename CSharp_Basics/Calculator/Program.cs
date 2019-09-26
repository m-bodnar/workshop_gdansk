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
                
                int parseA = GetValueFromUser("Podaj wartosc liczby A");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    return;
                }

                int parseB = GetValueFromUser("Podaj wartosc liczby B");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    return;
                }

                double result = 0;

                Console.WriteLine("Podaj operator");
                string operationSign = Console.ReadLine();
                
                if (operationSign == "q")
                {
                    Console.WriteLine("Zamykam aplikacje");
                    // Console.ReadKey();
                    // automatyczne zamykanie okna po 2 sekundach
                    Thread.Sleep(2000);
                    return;
                }
                
                result = Calculations.DoMath(operationSign, parseA, parseB);


                Console.WriteLine("Wynik to:" + " " + result);
            }
        }

        public static int GetValueFromUser(string message)
        {
            bool parssed = false;
            int parsedNumber = 0;
            while (!parssed)
            {
                Console.WriteLine(message);
                string valueFromUser = Console.ReadLine();
                if(valueFromUser == "q")
                {
                    quit = true;
                    return 0;
                }
                parssed = int.TryParse(valueFromUser, out parsedNumber);
                if(!parssed)
                {
                    message = $"Wartość {valueFromUser} nie jest liczbą. Podaj liczbę.";
                }
            }
            return parsedNumber;
        }
    }
}

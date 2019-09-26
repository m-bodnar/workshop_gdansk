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
                
                result = DoMath(operationSign, parseA, parseB);


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

        public static int DoMath(string operation, int parseA, int parseB)
        {
            int result = 0;
            
            switch (operation)
            {
                case "+":
                    result = Add(parseA, parseB);
                    break;
                case "-":
                    result = Subtract(parseA, parseB);
                    break;
                case "/":
                    if (parseA == 0)
                    {
                        Console.WriteLine("Nie dziel przez zero!");
                        break;
                    }
                    result = Divide(parseA, parseB);
                    break;
                case "x":
                case "*":
                    result = Multiply(parseA, parseB);
                    break;

                default:
                    Console.WriteLine("Nieznana operacja");
                    break;
            }

            return result;
        }


        public static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            int result = secondNumber - firstNumber;
            return result;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        public static int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }
    }
}

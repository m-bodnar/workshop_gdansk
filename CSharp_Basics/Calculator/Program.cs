using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Basic operations on integers:");

            //int x = 4;
            //int y = 6;

            //int add = x + y;
            //int subtract = y - x;
            //int multiply = x * y;

            //Console.WriteLine("x + y =" + " " + add);
            //Console.WriteLine("y - x =" + " " + subtract);
            //Console.WriteLine("x * y =" + " " + multiply);

            //// okno pozostaje otwarte; zamyka okno po naciśnięciu Enter
            //// Console.ReadLine();

            //// okno pozostaje otwarte; zamyka okno po naciśnięciu jakiegokolwiek przycisku
            //Console.ReadKey();

            //Console.WriteLine("Basic operations on integers:");

            //Console.WriteLine("Podaj wartosc liczby a");
            //string A = Console.ReadLine();
            //int parseA = int.Parse(A);

            //Console.WriteLine("Podaj wartosc liczby b");
            //string b = Console.ReadLine();
            //int parseB = int.Parse(b);

            //int add = parseA + parseB;
            //int subtract = parseB - parseA;

            //Console.WriteLine("a + b =" + " " + add);
            //Console.WriteLine("b - a =" + " " + subtract);

            //// okno pozostaje otwarte; zamyka okno po naciśnięciu Enter
            //// Console.ReadLine();

            //// okno pozostaje otwarte; zamyka okno po naciśnięciu jakiegokolwiek przycisku
            //Console.ReadKey();

            //Console.WriteLine("Basic operations on integers:");

            //Console.WriteLine("Podaj wartosc liczby a");
            //string A = Console.ReadLine();
            //int parseA = int.Parse(A);

            //Console.WriteLine("Podaj wartosc liczby b");
            //string b = Console.ReadLine();
            //int parseB = int.Parse(b);

            //int add = Add(parseA, parseB);
            //int subtract = Subtract(parseA, parseB);
            //int multiply = Multiply(parseA, parseB);
            //int divide = Divide(parseA, parseB);

            //Console.WriteLine("a + b =" + " " + add);
            //Console.WriteLine("b - a =" + " " + subtract);
            //Console.WriteLine("a * b =" + " " + multiply);
            //Console.WriteLine("a / b =" + " " + divide);

            //Console.ReadKey();

            //// + - / *
            //Console.WriteLine("Basic operations on integers:");

            //Console.WriteLine("Podaj wartosc liczby a");
            //string A = Console.ReadLine();
            //int parseA = int.Parse(A);

            //Console.WriteLine("Podaj wartosc liczby b");
            //string b = Console.ReadLine();
            //int parseB = int.Parse(b);

            //Console.WriteLine("Podaj operator");
            //string operation = Console.ReadLine();
            //double result = 0;

            //if (operation == "-")
            //{
            //    result = Subtract(parseA, parseB);
            //}

            //else if (operation == "+")
            //{
            //    result = Add(parseA, parseB);
            //}

            //else if (operation == "/")
            //{
            //    result = Divide(parseA, parseB);
            //}

            //else if (operation == "*")
            //{
            //    result = Multiply(parseA, parseB);
            //}
            //else
            //{
            //    Console.WriteLine("Nieznana operacja");
            //}

            //Console.WriteLine("Wynik to:" + " " + result);

            //Console.ReadKey();

            // bool isRunning = true;
            while (true)
            {

                int parseA = GetValueFromUser("Podaj wartosc liczby A");
                int parseB = GetValueFromUser("Podaj wartosc liczby B");

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

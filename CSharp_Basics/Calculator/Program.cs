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
            //string a = Console.ReadLine();
            //int parsea = int.Parse(a);

            //Console.WriteLine("Podaj wartosc liczby b");
            //string b = Console.ReadLine();
            //int parseb = int.Parse(b);

            //int add = parsea + parseb;
            //int subtract = parseb - parsea;

            //Console.WriteLine("a + b =" + " " + add);
            //Console.WriteLine("b - a =" + " " + subtract);

            //// okno pozostaje otwarte; zamyka okno po naciśnięciu Enter
            //// Console.ReadLine();

            //// okno pozostaje otwarte; zamyka okno po naciśnięciu jakiegokolwiek przycisku
            //Console.ReadKey();

            //Console.WriteLine("Basic operations on integers:");

            //Console.WriteLine("Podaj wartosc liczby a");
            //string a = Console.ReadLine();
            //int parsea = int.Parse(a);

            //Console.WriteLine("Podaj wartosc liczby b");
            //string b = Console.ReadLine();
            //int parseb = int.Parse(b);

            //int add = Add(parsea, parseb);
            //int subtract = Subtract(parsea, parseb);
            //int multiply = Multiply(parsea, parseb);
            //int divide = Divide(parsea, parseb);

            //Console.WriteLine("a + b =" + " " + add);
            //Console.WriteLine("b - a =" + " " + subtract);
            //Console.WriteLine("a * b =" + " " + multiply);
            //Console.WriteLine("a / b =" + " " + divide);

            //Console.ReadKey();

            //// + - / *
            //Console.WriteLine("Basic operations on integers:");

            //Console.WriteLine("Podaj wartosc liczby a");
            //string a = Console.ReadLine();
            //int parsea = int.Parse(a);

            //Console.WriteLine("Podaj wartosc liczby b");
            //string b = Console.ReadLine();
            //int parseb = int.Parse(b);

            //Console.WriteLine("Podaj operator");
            //string operation = Console.ReadLine();
            //double result = 0;

            //if (operation == "-")
            //{
            //    result = Subtract(parsea, parseb);
            //}

            //else if (operation == "+")
            //{
            //    result = Add(parsea, parseb);
            //}

            //else if (operation == "/")
            //{
            //    result = Divide(parsea, parseb);
            //}

            //else if (operation == "*")
            //{
            //    result = Multiply(parsea, parseb);
            //}
            //else
            //{
            //    Console.WriteLine("Nieznana operacja");
            //}

            //Console.WriteLine("Wynik to:" + " " + result);

            //Console.ReadKey();
            
            
            Console.WriteLine("Basic operations on integers:");

            Console.WriteLine("Podaj wartosc liczby a");
            string A = Console.ReadLine();
            int parseA = 0;
            if(!int.TryParse(A, out parseA))
            {
                Console.WriteLine($"Nieznana wartosc; używamy wartosci domyslnej {parseA}");
            }
            // int parsea = int.Parse(a);

            Console.WriteLine("Podaj wartosc liczby b");
            string B = Console.ReadLine();
            int parseB = 0;
            if (!int.TryParse(B, out parseB))
            {
                Console.WriteLine($"Nieznana wartosc; używamy wartosci domyslnej {parseB}");
            }
            // int parseb = int.Parse(b);

            Console.WriteLine("Podaj operator");
            string operation = Console.ReadLine();
            double result = 0;

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


            Console.WriteLine("Wynik to:" + " " + result);

            Console.ReadKey();
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

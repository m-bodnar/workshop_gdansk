using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
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
        
        private static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        private static int Subtract(int firstNumber, int secondNumber)
        {
            int result = secondNumber - firstNumber;
            return result;
        }

        private static int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        private static int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }
    }
}

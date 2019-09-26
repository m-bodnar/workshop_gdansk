using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
        public static double DoMath(MathData mathData)
        {
            int result = 0;

            switch (mathData.Operation)
            {
                case "+":
                    result = Add(mathData.firstNumber, mathData.secondNumber);
                    break;
                case "-":
                    result = Subtract(mathData.firstNumber, mathData.secondNumber);
                    break;
                case "/":
                    if (mathData.firstNumber == 0)
                    {
                        Console.WriteLine("Nie dziel przez zero!");
                        break;
                    }
                    result = Divide(mathData.firstNumber, mathData.secondNumber);
                    break;
                case "x":
                case "*":
                    result = Multiply(mathData.firstNumber, mathData.secondNumber);
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

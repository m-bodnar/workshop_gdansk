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
                    result = Add(mathData.FirstNumber, mathData.SecondNumber);
                    break;
                case "-":
                    result = Subtract(mathData.FirstNumber, mathData.SecondNumber);
                    break;
                case "/":
                    if (mathData.FirstNumber == 0)
                    {
                        Console.WriteLine("Nie dziel przez zero!");
                        break;
                    }
                    result = Divide(mathData.FirstNumber, mathData.SecondNumber);
                    break;
                case "x":
                case "*":
                    result = Multiply(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                default:
                    Console.WriteLine("Nieznana operacja");
                    break;
            }

            return result;
        }
        
        private static int Add(int FirstNumber, int SecondNumber)
        {
            int result = FirstNumber + SecondNumber;
            return result;
        }

        private static int Subtract(int FirstNumber, int SecondNumber)
        {
            int result = SecondNumber - FirstNumber;
            return result;
        }

        private static int Multiply(int FirstNumber, int SecondNumber)
        {
            int result = FirstNumber * SecondNumber;
            return result;
        }

        private static int Divide(int FirstNumber, int SecondNumber)
        {
            int result = FirstNumber / SecondNumber;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class GetInformationFromUser
    {
        public static void Quit()
        {
            Console.WriteLine("Zamykam aplikację");
            Environment.Exit(0);
        }
        private static bool IsQuit(string userInput)
        {
            return userInput == "q";
        }
        public static MathData GetAllValuesFromCustromer()
        {
            int first = GetInformationFromUser.GetValueFromUser("Podaj wartosc liczby A");
            int second = GetInformationFromUser.GetValueFromUser("Podaj wartosc liczby B");
            string operation = GetInformationFromUser.GetOperationFromUser();

            return new MathData(first, second, operation);
        }
        public static int GetValueFromUser(string message)
        {
            bool parssed = false;
            int parsedNumber = 0;
            while (!parssed)
            {
                Console.WriteLine(message);
                string valueFromUser = Console.ReadLine();
                if (IsQuit(valueFromUser))
                {
                    Quit();
                }
                parssed = int.TryParse(valueFromUser, out parsedNumber);
                if (!parssed)
                {
                    message = $"Wartość {valueFromUser} nie jest liczbą. Podaj liczbę.";
                }
            }
            return parsedNumber;
        }
        public static string GetOperationFromUser()
        {
            Console.WriteLine("Podaj operator");
            string operationSign = Console.ReadLine();

            if (IsQuit(operationSign))
            {
                Quit();
            }
            return operationSign;
        }
    }
}

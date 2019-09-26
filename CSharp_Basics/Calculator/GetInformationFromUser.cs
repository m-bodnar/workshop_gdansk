using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class GetInformationFromUser
    {
        public static int GetValueFromUser(string message)
        {
            bool parssed = false;
            int parsedNumber = 0;
            while (!parssed)
            {
                Console.WriteLine(message);
                string valueFromUser = Console.ReadLine();
                if (valueFromUser == "q")
                {
                    Console.WriteLine("Zamykam aplikację");
                    Environment.Exit(0);
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

            if (operationSign == "q")
            {
                Console.WriteLine("Zamykam aplikację");
                Environment.Exit(0);
            }
            return operationSign;
        }
    }
}

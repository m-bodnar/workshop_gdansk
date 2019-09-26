using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathData
    {
        public int FirstNumber;
        public int SecondNumber;
        public string Operation;

        public MathData(int firstNumber, int secondNumber, string operation)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operation = operation;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Calculator
{
    public class Calculator
    {
        public double Calculate(double num1, double num2, ICalculatorOperation operation)
        {
            return operation.PerformOperation(num1, num2);
        }
    }
}

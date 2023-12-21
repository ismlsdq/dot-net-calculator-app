using CalculatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Operations
{
    public class Subtraction : ICalculatorOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}

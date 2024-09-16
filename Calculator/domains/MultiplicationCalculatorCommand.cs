using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.domains
{
    internal class MultiplicationCalculatorCommand : ICalculatorCommand
    {
        private Calculator Calculator {  get; set; }

        public MultiplicationCalculatorCommand(Calculator calculator) 
        {
            Calculator = calculator;
        }

        public void Execute()
        {
            Calculator.SetOperation((a, b) => a * b);
        }
    }
}

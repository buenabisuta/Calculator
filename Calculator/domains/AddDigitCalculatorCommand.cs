using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.domains
{
    internal class AddDigitCalculatorCommand : ICalculatorCommand
    {
        private Calculator Calculator {  get; set; }
        private string Digit {  get; set; }

        public AddDigitCalculatorCommand(Calculator calculator, string digit) 
        {
            Calculator = calculator;
            Digit = digit;
        }

        public void Execute()
        {
            Calculator.AddDigit(Digit);
        }
    }
}

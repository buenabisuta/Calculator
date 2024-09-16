using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.domains
{
    internal class EqualCalculatorCommand : ICalculatorCommand
    {
        private Calculator Calculator {  get; set; }

        public EqualCalculatorCommand(Calculator calculator) 
        {
            Calculator = calculator;
        }

        public void Execute()
        {
            Calculator.Calculate();
        }
    }
}

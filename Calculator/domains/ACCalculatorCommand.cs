using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.domains
{
    internal class ACCalculatorButton : ICalculatorCommand
    {
        private Calculator Calculator {  get; set; }

        public ACCalculatorButton(Calculator calculator) 
        {
            Calculator = calculator;
        }

        public void Execute()
        {
            Calculator.FormInitialize();
        }
    }
}

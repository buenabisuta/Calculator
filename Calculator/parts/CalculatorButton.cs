using Calculator.domains;
using Calculator.externalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.parts
{
    internal class CalculatorButton
    {
        private readonly string Label;
        private readonly ICalculatorCommand CalculatorCommand;

        private readonly Logger Logger = new Logger();

        public CalculatorButton(string label, ICalculatorCommand calculatorCommand) 
        {
            Label = label;
            CalculatorCommand = calculatorCommand;
        }

        public void Press()
        {
            Logger.Info($"{Label}ボタンを押下しました。");
            CalculatorCommand.Execute();
        }
    }
}

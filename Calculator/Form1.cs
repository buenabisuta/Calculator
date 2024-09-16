using Calculator.domains;
using Calculator.parts;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private domains.Calculator Calculator;
        private CalculatorButton ZeroButton;
        private CalculatorButton OneButton;
        private CalculatorButton TwoButton;
        private CalculatorButton ThreeButton;
        private CalculatorButton FourButton;
        private CalculatorButton FiveButton;
        private CalculatorButton SixButton;
        private CalculatorButton SevenButton;
        private CalculatorButton EightButton;
        private CalculatorButton NineButton;
        private CalculatorButton DotButton;

        private CalculatorButton PlusCalculatorButton;
        private CalculatorButton MinusCalculatorButton;
        private CalculatorButton CrossCalculatorButton;
        private CalculatorButton DivideCalculatorButton;
        private CalculatorButton EqualCalculatorButton;
        private CalculatorButton ACCalculatorButton;


        public Form1()
        {
            InitializeComponent();

            Calculator = new domains.Calculator();
            resultTextBox.DataBindings.Add("Text", Calculator, "CurrentInputValue", false, DataSourceUpdateMode.OnPropertyChanged);

            var zeroDigit = "0";
            ZeroButton = new CalculatorButton(zeroDigit, new AddDigitCalculatorCommand(Calculator, zeroDigit));

            var oneDigit = "1";
            OneButton = new CalculatorButton(oneDigit, new AddDigitCalculatorCommand(Calculator, oneDigit));

            var twoDigit = "2";
            TwoButton = new CalculatorButton(twoDigit, new AddDigitCalculatorCommand(Calculator, twoDigit));

            var threeDigit = "3";
            ThreeButton = new CalculatorButton(threeDigit, new AddDigitCalculatorCommand(Calculator, threeDigit));

            var fourDigit = "4";
            FourButton = new CalculatorButton(fourDigit, new AddDigitCalculatorCommand(Calculator, fourDigit));

            var fiveDigit = "5";
            FiveButton = new CalculatorButton(fiveDigit, new AddDigitCalculatorCommand(Calculator, fiveDigit));

            var sixDigit = "6";
            SixButton = new CalculatorButton(sixDigit, new AddDigitCalculatorCommand(Calculator, sixDigit));

            var sevenDigit = "7";
            SevenButton = new CalculatorButton(sevenDigit, new AddDigitCalculatorCommand(Calculator, sevenDigit));

            var eightDigit = "8";
            EightButton = new CalculatorButton(eightDigit, new AddDigitCalculatorCommand(Calculator, eightDigit));

            var nineDigit = "9";
            NineButton = new CalculatorButton(nineDigit, new AddDigitCalculatorCommand(Calculator, nineDigit));

            var dotDigit = ".";
            DotButton = new CalculatorButton(dotDigit, new AddDigitCalculatorCommand(Calculator, dotDigit));

            var plusDigit = "+";
            PlusCalculatorButton = new CalculatorButton(plusDigit, new AdditionCalculatorCommand(Calculator));

            var minusDigit = "-";
            MinusCalculatorButton = new CalculatorButton(minusDigit, new SubtractionCalculatorCommand(Calculator));

            var crossDigit = "Å~";
            CrossCalculatorButton = new CalculatorButton(crossDigit, new MultiplicationCalculatorCommand(Calculator));

            var divideDigit = "ÅÄ";
            DivideCalculatorButton = new CalculatorButton(divideDigit, new DivisionCalculatorCommand(Calculator));

            var equalDigit = "=";
            EqualCalculatorButton = new CalculatorButton(equalDigit, new EqualCalculatorCommand(Calculator));

            var ACDigit = "AC";
            ACCalculatorButton = new CalculatorButton(ACDigit, new ACCalculatorButton(Calculator));
        }

        private void ZeroDigitButton_Click(object sender, EventArgs e)
        {
            ZeroButton.Press();
        }

        private void OneDigitButton_Click(object sender, EventArgs e)
        {
            OneButton.Press();
        }

        private void TwoDigitButton_Click(object sender, EventArgs e)
        {
            TwoButton.Press();
        }

        private void ThreeDigitButton_Click(object sender, EventArgs e)
        {
            ThreeButton.Press();
        }

        private void FourDigitButton_Click(object sender, EventArgs e)
        {
            FourButton.Press();
        }

        private void FiveDigitButton_Click(object sender, EventArgs e)
        {
            FiveButton.Press();
        }

        private void SixDigitButton_Click(object sender, EventArgs e)
        {
            SixButton.Press();
        }

        private void SevenDigitButton_Click(object sender, EventArgs e)
        {
            SevenButton.Press();
        }

        private void EightDigitButton_Click(object sender, EventArgs e)
        {
            EightButton.Press();
        }

        private void NineDigitButton_Click(object sender, EventArgs e)
        {
            NineButton.Press();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            PlusCalculatorButton.Press();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            EqualCalculatorButton.Press();
        }

        private void DotDigitButton_Click(object sender, EventArgs e)
        {
            DotButton.Press();
        }

        private void AllClearButton_Click(object sender, EventArgs e)
        {
            ACCalculatorButton.Press();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            DivideCalculatorButton.Press();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            CrossCalculatorButton.Press();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            MinusCalculatorButton.Press();
        }
    }
}

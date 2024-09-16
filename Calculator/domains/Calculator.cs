using log4net;
using System.ComponentModel;

namespace Calculator.domains
{
    internal class Calculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string CurrentInputValue { get; private set; } = "";

        private double? PreviousValue { get; set; } = null;
        private double? CalculateResult { get; set; } = null;
        private Func<double, double, double>? CurrentOperation { get; set; }

        public void AddDigit(string digit)
        {
            // 小数点第5位以上の入力ができないようにする。
            if (CurrentInputValue.Contains(".") && CurrentInputValue.Substring(CurrentInputValue.IndexOf(".") + 1).Length == 5)
            {
                return;
            }

            if (digit == ".")
            {
                var currentInputValue = string.IsNullOrEmpty(CurrentInputValue) ? "0" : CurrentInputValue;
                SetCurrentInputValue(currentInputValue + digit);
                return;
            }

            if (int.TryParse(digit, out var intDigit) && (0 <= intDigit && intDigit <= 9))
            {
                SetCurrentInputValue(CurrentInputValue + digit);
                return;
            }
            throw new Exception("電卓で使われない文字列です。");
        }

        public void SetOperation(Func<double, double, double> operation)
        {
            if (!double.TryParse(CurrentInputValue, out double currentInputValue))
                return;

            CurrentOperation = operation;

            PreviousValue = PreviousValue.HasValue ? 
                CurrentOperation(PreviousValue.Value, currentInputValue) :
                currentInputValue;
            SetCurrentInputValue("");
        }

        public void Calculate()
        {
            if (CurrentOperation == null)
                return;
            if (!double.TryParse(CurrentInputValue, out double currentInputValue))
                return;
            if (!PreviousValue.HasValue)
                return;

            CalculateResult = CurrentOperation(PreviousValue.Value, currentInputValue);

            if (!CalculateResult.HasValue)
            {
                throw new Exception("予期しないエラーが起きました。");
            }
            SetCurrentInputValue(CalculateResult.Value.ToString());

            CurrentOperation = null;
            PreviousValue = null;
        }

        public void SetCurrentInputValue(string value)
        {
            CurrentInputValue = value;
            OnPropertyChanged(nameof(CurrentInputValue));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentInputValue"));
        }

        public void FormInitialize()
        {
            CurrentOperation = null;
            PreviousValue = null;
            CalculateResult = null;
            SetCurrentInputValue("");
        }
    }


}

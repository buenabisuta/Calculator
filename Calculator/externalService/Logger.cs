namespace Calculator.externalService
{
    // TODO: log4netを利用してログを出力するようにしています。
    // 現状、ログの出力ができない状態です。
    // AssemblyInfo.cs もしくは log4net.config の設定関係が問題していると感じています。
    internal class Logger
    {
        private static readonly log4net.ILog _Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Info(string infoMessage)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine(infoMessage);
#else
            _Logger.Info(infoMessage);
#endif
        }
    }
}

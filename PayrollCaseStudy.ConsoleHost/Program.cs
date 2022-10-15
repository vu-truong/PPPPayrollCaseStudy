using PayrollCaseStudy.PayrollApplication;
using System.IO;

namespace PayrollCaseStudy.ConsoleHost {
    class Program {
        static void Main(string[] args) {
            var reader = new StreamReader(new FileStream("TestTransactions.txt",FileMode.Open,FileAccess.Read));
            var parser = new TextParserTransactionSource(reader);
            var app = new PayrollApplication.PayrollApplication(parser);
            app.Process();
            return;
        }
    }
}

using PayrollCaseStudy.PayrollApplication;
using System.IO;

namespace PayrollCaseStudy.ConsoleHost {
    class Program {
        static void Main(string[] args) {
            PayrollDatabase.Scope.DatabaseInstance = InMemPayrollDatbase.Database.Instance;
            var reader = new StreamReader(new FileStream("TestTransactions.txt",FileMode.Open,FileAccess.Read));
            var parser = new TextParserTransactionSource(reader);
            var app = new Application(parser);
            app.Process();
            return;
        }
    }
}

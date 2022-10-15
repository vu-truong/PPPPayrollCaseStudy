using PayrollCaseStudy.PayrollApplication;
using System.IO;

namespace PayrollCaseStudy.ConsoleHost {
    class Program {

/*
Consider what happens if we make a change to the Classifications component.
This change will force a recompilation and retest of the PayrollDatabase component,
and well it should. But it will also force a recompilation and retest of the Transactions
*/
        static void Main(string[] args) {
            var reader = new StreamReader(new FileStream("TestTransactions.txt",FileMode.Open,FileAccess.Read));
            var parser = new TextParserTransactionSource(reader);
            var app = new PayrollApplication.PayrollApplication(parser);
            app.Process();
            return;
        }
    }
}

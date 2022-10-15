using PayrollCaseStudy.PayrollApplication;
using System.IO;

namespace PayrollCaseStudy.ConsoleHost
{
    class PayrollApplication : TransactionApplication.TransactionApplication{
        public PayrollApplication(TextParserTransactionSource source)  : base(source){
        }

        static void Main(string[] args) {
            PayrollDatabase.Scope.PayrollDatabase = InMemPayrollDatabase.InMemPayrollDatabase.Instance;
            TransactionFactory.Scope.TransactionFactory = new TransactionImplementation.PayrollTransactionFactory();
            PayrollFactory.Scope.PayrollFactory = new PayrollImplementation.Factory();

            var reader = new StreamReader(new FileStream("TestTransactions.txt",FileMode.Open,FileAccess.Read));
            var parser = new TextParserTransactionSource(reader);
            var app = new PayrollApplication(parser);
            app.Process();
            return;
        }
    }
}

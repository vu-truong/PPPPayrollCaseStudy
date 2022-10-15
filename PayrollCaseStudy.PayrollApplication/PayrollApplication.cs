﻿using System.IO;

namespace PayrollCaseStudy.PayrollApplication
{
    class PayrollApplication : TransactionApplication.TransactionApplication{
        public PayrollApplication(TextParserTransactionSource source)  : base(source){
        }

        static void Main(string[] args) {
            PayrollDatabase.Scope.PayrollDatabase = InMemPayrollDatbase.InMemPayrollDatabase.Instance;
            var reader = new StreamReader(new FileStream("TestTransactions.txt",FileMode.Open,FileAccess.Read));
            var parser = new TextParserTransactionSource(reader);
            var app = new PayrollApplication(parser);
            app.Process();
            return;
        }
    }
}

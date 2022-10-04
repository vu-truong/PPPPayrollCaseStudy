using PayrollCaseStudy.TransactionApplication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCaseStudy.TransactionApplication {
    public class TransactionApplicaion {
        readonly TransactionSource _source;
        public TransactionApplicaion(TransactionSource transactionSource) {
            _source= transactionSource;
            
        }

        [DebuggerStepThrough]
        public void Process() {
            while(true) { 
                Transaction transaction;
                try {
                    transaction = _source.Next();
                }
                catch (Exception e) {
                    Console.Error.WriteLine("Failed processing line:\n{0}", e);
                    continue;
                }

                if(transaction == null) {
                    return;
                }
                transaction.Execute();
            }
        }
    }
}

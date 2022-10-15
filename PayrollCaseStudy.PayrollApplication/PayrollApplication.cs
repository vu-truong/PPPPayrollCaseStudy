using PayrollCaseStudy.PayrollDomain;
using System;
using System.Diagnostics;

namespace PayrollCaseStudy.PayrollApplication {
/*
The PayrollApplication component contains the
PayrollApplication and TransactionSource classes. Both of these two classes
depend on the abstract Transaction class, which is in the PayrollDomain component.
Note that the TextParserTransactionSource class is in another component that
depends on the abstract PayrollApplication class. This creates an upside-down structure 
in which the details depend on the generalities, and the generalities are independent.
This conforms to DIP.

The most striking case of generality and independence is the PayrollDomain component. 
This component contains the essence of the whole system, yet it depends upon
nothing! Examine this component carefully. It contains Employee, PaymentClassification, 
PaymentMethod, PaymentSchedule, Affiliation, and Transaction.
This component contains all the major abstractions in our model, yet it has no dependencies. 
Why? Because all the classes it contains are abstract
*/
    public class PayrollApplication {
        readonly TransactionSource _source;
        public PayrollApplication(TransactionSource transactionSource) {
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

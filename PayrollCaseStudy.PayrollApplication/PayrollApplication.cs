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

Consider the Classifications component, which contains the three derivatives of
PaymentClassification, along with the ChangeClassificationTransaction
class and its three derivatives, as well as TimeCard and SalesReceipt. Note that any
change made to these nine classes is isolated; other than TextParser, no other component 
is affected! Such isolation also holds for the Methods component, the Schedules
component and the Affiliations component. This is quite a bit of isolation.
*/

/*
Note that the bulk of the detailed code that will eventually be written is in components
that have few or no dependents. Since almost nothing depends on them, we call them irresponsible. The code within those components is tremendously flexible; it can be changed
without affecting many other parts of the project. Note also that the most general packages
of the system contain the least amount of code. These components are heavily depended
on but depend on nothing. Since many components depend on them, we call them responsible, and since they don’t depend upon anything, we call them independent. Thus, the
amount of responsible code (i.e., code in which changes would affect lots of other code) is
very small. Moreover, that small amount of responsible code is also independent, which
means that no other modules will induce it to change. This upside-down structure, with
highly independent and responsible generalities at the bottom and highly irresponsible and
dependent details at the top, is the hallmark of object-oriented design.

Compare Figure 30-1 with Figure 30-2. Note that the details at the bottom of Figure
30-1 are independent and highly responsible. This is the wrong place for details! Details
should depend on the major architectural decisions of the system and should not be
depended on. Note also that the generalities—the components that define the architecture
of the system—are irresponsible and highly dependent. Thus, the components that define
the architectural decisions depend on, and are thus constrained by, the components that
contain the implementation details. This is a violation of SAP. It would be better if the
architecture constrained the details!
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

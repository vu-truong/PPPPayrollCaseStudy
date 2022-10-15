using PayrollCaseStudy.Transactions;
using System;
using System.Diagnostics;

namespace PayrollCaseStudy.PayrollApplication
{
/*
Consider what happens if we make a change to the Classifications component.
This change will force a recompilation and retest of the PayrollDatabase component,
and well it should. But it will also force a recompilation and retest of the Transactions
component. Certainly, the ChangeClassificationTransaction and its three derivatives from 
Figure 27-13 should be recompiled and retested, but why should the others be
recompiled and retested?

Technically, those other transactions don’t need recompilation and retest. However, if
they are part of the Transactions component, and if that component is going to be
rereleased to deal with the changes to the Classifications component, it could be
viewed as irresponsible not to recompile and retest the component as a whole. Even if all
the transactions aren’t recompiled and retested, the package itself must be rereleased and
redeployed, and then all its clients will require revalidation at the very least and probably
recompilation as well.

The classes in the Transactions component do not share the same closure. Each
one is sensitive to its own particular changes. The ServiceChargeTransaction is open
to changes to the ServiceCharge class, whereas the TimeCardTransaction is open to
changes to the TimeCard class. In fact, as Figure 30-1 implies, some portion of the
Transactions component is dependent on nearly every other part of the software. Thus,
this component suffers a high rate of release. Every time something is changed anywhere
below, the Transactions component will have to be revalidated and rereleased.

The PayrollApplication package is even more sensitive: Any change to any part
of the system will affect this package, so its release rate must be enormous. You might
think that this is inevitable—that as one climbs higher up the package-dependency hierarchy, the release rate must increase. Fortunately, however, this is not true, and avoiding this
symptom is one of the major goals of OOD.
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

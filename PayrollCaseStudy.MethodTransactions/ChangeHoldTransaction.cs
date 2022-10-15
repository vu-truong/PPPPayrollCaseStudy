using PayrollCaseStudy.Methods;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.MethodTransactions
{
    public class ChangeHoldTransaction : ChangeMethodTransaction{
        
        public ChangeHoldTransaction(int empId) :base(empId){
        }
        protected override PaymentMethod GetMethod() {
            return new HoldMethod();
        }
    }
}

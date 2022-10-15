using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.TransactionImplementation
{
    public class ChangeHoldTransaction : ChangeMethodTransaction{
        
        public ChangeHoldTransaction(int empId) :base(empId){
        }
        protected override PaymentMethod GetMethod() {
            return PayrollFactory.Scope.PayrollFactory.MakeHoldMethod();
            
        }
    }
}

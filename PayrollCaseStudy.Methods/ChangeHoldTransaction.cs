using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Methods
{
    public class ChangeHoldTransaction : ChangeMethodTransaction{
        
        public ChangeHoldTransaction(int empId) :base(empId){
        }
        protected override PaymentMethod GetMethod() {
            return new HoldMethod();
        }
    }
}

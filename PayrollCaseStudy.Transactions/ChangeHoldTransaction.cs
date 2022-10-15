using PayrollCaseStudy.Methods;

namespace PayrollCaseStudy.Transactions
{
    public class ChangeHoldTransaction : ChangeMethodTransaction{
        
        public ChangeHoldTransaction(int empId) :base(empId){
        }
        protected override PaymentMethod GetMethod() {
            return new HoldMethod();
        }
    }
}

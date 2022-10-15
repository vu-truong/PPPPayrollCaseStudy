using PayrollCaseStudy.GeneralTransactions;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.MethodTransactions
{
    public abstract class ChangeMethodTransaction : ChangeEmployeeTransaction{
        
        public ChangeMethodTransaction(int empId) :base(empId){
        }
        protected override void Change(Employee e) {
            e.Method = GetMethod();
        }

        protected abstract PaymentMethod GetMethod();
    }
}

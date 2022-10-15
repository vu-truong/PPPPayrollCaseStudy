using PayrollCaseStudy.Methods;
using PayrollCaseStudy.PayrollDatabase;

namespace PayrollCaseStudy.Transactions
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

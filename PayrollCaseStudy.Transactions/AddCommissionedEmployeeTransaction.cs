using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.Schedules;

namespace PayrollCaseStudy.Transactions
{
    public class AddCommissionedEmployeeTransaction : AddEmployeeTransaction{
        private decimal _salary;
        private decimal _commissionRate;
        
        public AddCommissionedEmployeeTransaction(int empId,string name,string address,decimal salary,decimal commissionRate)  : base(empId, name,address) {
            _salary = salary;
            _commissionRate = commissionRate;
        }

        protected override PaymentSchedule GetSchedule() {
            return new BiweeklySchedule();
        }

        protected override PaymentClassification GetClassification() {
            return new CommissionedClassification(_salary,_commissionRate);
        }
    }
}

using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.Schedules;

namespace PayrollCaseStudy.Transactions
{
    public class AddSalariedEmployeeTransaction : AddEmployeeTransaction{
        private decimal _itsSalary;

        public AddSalariedEmployeeTransaction(int employeeId, string name, string address, decimal salary) : base(employeeId,name,address) {
            _itsSalary = salary;
        }

        protected override PaymentSchedule GetSchedule() {
            return new MonthlySchedule();
        }

        protected override PaymentClassification GetClassification() {
            return new SalariedClassification(_itsSalary);
        }
    }
}

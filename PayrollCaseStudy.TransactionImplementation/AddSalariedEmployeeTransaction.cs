using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.TransactionImplementation {
    public class AddSalariedEmployeeTransaction : AddEmployeeTransaction{
        private decimal _itsSalary;

        public AddSalariedEmployeeTransaction(int employeeId, string name, string address, decimal salary) : base(employeeId,name,address) {
            _itsSalary = salary;
        }

        protected override PaymentSchedule GetSchedule() {
            return PayrollFactory.Scope.PayrollFactory.MakeMonthlySchedule();
        }

        protected override PaymentClassification GetClassification() {
            return PayrollFactory.Scope.PayrollFactory.MakeSalariedClassification(_itsSalary);
            
        }
    }
}

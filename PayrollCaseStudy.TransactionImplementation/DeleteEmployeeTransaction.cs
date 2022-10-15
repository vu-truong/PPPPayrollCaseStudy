using PayrollCaseStudy.TransactionApplication;

namespace PayrollCaseStudy.TransactionImplementation
{
    public class DeleteEmployeeTransaction : Transaction{
        private int _employeeId;

        public DeleteEmployeeTransaction(int empId) {
            this._employeeId = empId;
        }

        public void Execute() {
            PayrollDatabase.Scope.PayrollDatabase.DeleteEmployee(_employeeId);
        }
    }
}

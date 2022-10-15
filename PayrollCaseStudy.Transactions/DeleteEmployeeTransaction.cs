namespace PayrollCaseStudy.Transactions
{
    public class DeleteEmployeeTransaction : Transaction{
        private int _employeeId;

        public DeleteEmployeeTransaction(int empId) {
            this._employeeId = empId;
        }

        public void Execute() {
            PayrollDatabase.PayrollDatabase.Instance.DeleteEmployee(_employeeId);
        }
    }
}

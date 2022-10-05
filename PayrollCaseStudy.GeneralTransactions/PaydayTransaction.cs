using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.PayrollDomain;
using PayrollCaseStudy.TransactionApplication;
using System.Collections.Generic;

namespace PayrollCaseStudy.GeneralTransactions {
    public class PaydayTransaction : Transaction{
        private Date _forPayDate;
        Dictionary<int,Paycheck> _paychecks = new Dictionary<int,Paycheck>();

        public PaydayTransaction(Date payDate) {
            _forPayDate = payDate;
        }

        public void Execute() {
            var empIds = PayrollDatabase.Scope.PayrollDatabase.GetAllEmployeeIds();

            foreach(var empId in empIds) {
                var employee = PayrollDatabase.Scope.PayrollDatabase.GetEmployee(empId);
                if(employee == null) {
                    continue;
                }
                if(!employee.IsPayDate(_forPayDate)) {
                    continue;
                }
                var paycheck = new Paycheck(employee.GetPayPeriodStartDate(_forPayDate), _forPayDate);
                _paychecks[empId] = paycheck;
                employee.Payday(paycheck);

            }
        }

        public Paycheck GetPaycheck(int empId) {
            if(!_paychecks.ContainsKey(empId)) {
                return null;
            }
            return _paychecks[empId];
        }
    }
}

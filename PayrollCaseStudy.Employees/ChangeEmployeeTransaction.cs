﻿using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Employees
{
    public abstract class ChangeEmployeeTransaction : Transaction{
        private int _empId;

        protected abstract void Change(Employee e);

        public ChangeEmployeeTransaction(int empId) {
            _empId = empId;
        }

        public void Execute() {
            var employee = PayrollDatabase.Scope.PayrollDatabase.GetEmployee(_empId);
            if(employee!=null) {
                Change(employee);
            }
        }
    }
}

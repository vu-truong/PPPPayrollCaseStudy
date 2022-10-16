﻿using PayrollCaseStudy.PayrollDatabase;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Employees
{
    public abstract class AddEmployeeTransaction: Transaction {
        private string _address;
        private string _name;
        private int _employeeId;

        public AddEmployeeTransaction(int employeeId, string name, string address) {
            _employeeId = employeeId;
            _name = name;
            _address = address;
        }

        public virtual void Execute() {
            PaymentClassification classification = GetClassification();
            PaymentSchedule paymentSchedule = GetSchedule();
            //PaymentMethod method = new HoldMethod();
            var employee=  new Employee(_employeeId,_name,_address);
            employee.Classification = classification;
            employee.Schedule = paymentSchedule;
            //employee.Method = method;
            Scope.PayrollDatabase.AddEmployee(_employeeId, employee);
        }

        protected abstract PaymentSchedule GetSchedule(); 
        protected abstract PaymentClassification GetClassification();
    }
}
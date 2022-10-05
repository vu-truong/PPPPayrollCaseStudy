﻿using PayrollCaseStudy.PayrollDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCaseStudy.EmployeeDataTransactions {
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

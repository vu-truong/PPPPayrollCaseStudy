﻿using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.PayrollDomain;
using System;

namespace PayrollCaseStudy.Classifications
{
    public class SalesReceiptTransaction : Transaction{
        private decimal _amount;
        private Date _forDate;
        private int _employeeId;
        
        public SalesReceiptTransaction(decimal amount,Date forDate, int employeeId) {
            _forDate = forDate;    
            _amount = amount;
            _employeeId = employeeId;
        }
        public void Execute() {
            var employee =  PayrollDatabase.Scope.PayrollDatabase.GetEmployee(_employeeId);

            if(employee == null) {
                throw new Exception("Employee not found");
            }

            var commissioned = employee.GetClassification() as CommissionedClassification;
            if(commissioned == null) {
                throw new Exception("Employee not commissioned");
            }

            commissioned.AddSalesReceipt(new SalesReceipt(_amount,_forDate));
        }
    }
}
﻿using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.Schedules;

namespace PayrollCaseStudy.Transactions
{
    public class ChangeSalariedTransaction : ChangeClassificationTransaction{
        private decimal _monthlySalary;
        
        public ChangeSalariedTransaction(int empId,decimal monthlySalary) : base(empId) {
            _monthlySalary = monthlySalary;
        }

        protected override PaymentClassification GetClassification() {
            return new SalariedClassification(_monthlySalary);
        }

        protected override PaymentSchedule GetSchedule() {
            return new MonthlySchedule();
        }
    }
}

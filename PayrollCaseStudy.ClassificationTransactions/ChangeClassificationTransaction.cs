﻿using PayrollCaseStudy.GeneralTransactions;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.ClassificationTransactions {
    public abstract class ChangeClassificationTransaction : ChangeEmployeeTransaction{
        public ChangeClassificationTransaction(int employeeId) : base(employeeId) {
        }
        
        protected override void Change(Employee e) {
            e.Classification = GetClassification();
            e.Schedule = GetSchedule();
        }

        protected abstract PaymentClassification GetClassification();
        protected abstract PaymentSchedule GetSchedule();

    }
}
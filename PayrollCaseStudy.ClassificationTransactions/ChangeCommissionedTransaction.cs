﻿using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.ClassificationTransactions {
    public class ChangeCommissionedTransaction : ChangeClassificationTransaction{
        private decimal _salary;
        private decimal _commissionRate;

        public ChangeCommissionedTransaction(int empId,decimal salary,decimal commisionRate)  :base(empId){
            
            this._salary = salary;
            this._commissionRate = commisionRate;
        }
        protected override PaymentClassification GetClassification() {
            return new CommissionedClassification(_salary,_commissionRate);
        }

        protected override PaymentSchedule GetSchedule() {
            return new BiweeklySchedule();
        }
    }
}

﻿using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.PayrollDomain;
using PayrollCaseStudy.TransactionApplication;

namespace PayrollCaseStudy.TransactionImplementation
{
    public class ServiceChargeTransaction : Transaction{
        private decimal _charge;
        private Date _forDate;
        private int _memberId;
        
        public ServiceChargeTransaction(int memberId,Date forDate,decimal charge) {
            _memberId = memberId;
            _forDate = forDate;
            _charge = charge;
        }
        public void Execute() {
            Employee e = PayrollDatabase.Scope.PayrollDatabase.GetUnionMember(_memberId);

            e.Affiliation.AddServiceCharge(_forDate,_charge);
        }
    }
}

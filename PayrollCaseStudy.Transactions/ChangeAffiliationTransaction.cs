﻿using PayrollCaseStudy.Affiliations;
using PayrollCaseStudy.PayrollDatabase;

namespace PayrollCaseStudy.Transactions {
    public abstract class ChangeAffiliationTransaction : ChangeEmployeeTransaction{
        
        public ChangeAffiliationTransaction(int empId) : base(empId){

        }

        protected abstract Affiliation GetAffiliation();
        protected abstract void RecordMembership(Employee e);


        protected override void Change(Employee e) {
            RecordMembership(e);
            e.Affiliation = GetAffiliation();
        }
    }
}

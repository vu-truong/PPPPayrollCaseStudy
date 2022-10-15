﻿using PayrollCaseStudy.Affiliations;
using PayrollCaseStudy.PayrollDatabase;

namespace PayrollCaseStudy.Transactions
{
    public class ChangeUnaffiliatedTransaction : ChangeAffiliationTransaction{
        public ChangeUnaffiliatedTransaction(int empId) : base(empId){
        }
        protected override Affiliation GetAffiliation() {
            return new NoAffiliation();
        }

        protected override void RecordMembership(Employee e) {
            var affiliation = e.Affiliation as UnionAffiliation;

            if(affiliation==null) {
                return;
            }
            PayrollDatabase.PayrollDatabase.Instance.RemoveUnionMember(affiliation.MemberId);
        }
    }
}

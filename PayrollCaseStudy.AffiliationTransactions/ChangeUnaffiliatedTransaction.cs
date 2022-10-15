using PayrollCaseStudy.Affiliations;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.AffiliationTransactions
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
            PayrollDatabase.Scope.PayrollDatabase.RemoveUnionMember(affiliation.MemberId);
        }
    }
}

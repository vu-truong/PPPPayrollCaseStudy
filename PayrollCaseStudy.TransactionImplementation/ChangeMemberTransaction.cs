using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.TransactionImplementation
{
    public class ChangeMemberTransaction : ChangeAffiliationTransaction{
        private int _empId;
        private int _memberId;
        private decimal _weeklyDues;

        public ChangeMemberTransaction(int empId,int memberId,decimal weeklyDues)  :base(empId){
            _empId = empId;
            _memberId = memberId;
            _weeklyDues = weeklyDues;
        }


        protected override Affiliation GetAffiliation() {
            return PayrollFactory.Scope.PayrollFactory.MakeUnionAffiliation(_memberId, _weeklyDues);
            
        }

        protected override void RecordMembership(Employee e) {
            PayrollDatabase.Scope.PayrollDatabase.AddUnionMember(_memberId,e);
        }
    }
}

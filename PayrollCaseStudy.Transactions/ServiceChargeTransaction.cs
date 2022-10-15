using PayrollCaseStudy.Affiliations;
using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.PayrollDatabase;

namespace PayrollCaseStudy.Transactions
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
            Employee e = PayrollDatabase.PayrollDatabase.Instance.GetUnionMember(_memberId);

            var unionAffiliation = e.Affiliation as UnionAffiliation;

            if(unionAffiliation!=null) {
                unionAffiliation.AddServiceCharge(_forDate,_charge);
            }
        }
    }
}

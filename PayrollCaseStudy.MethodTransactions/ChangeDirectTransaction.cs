using PayrollCaseStudy.Methods;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.MethodTransactions
{
    public class ChangeDirectTransaction : ChangeMethodTransaction{
        private string _account;
        private string _bank;
        
        public ChangeDirectTransaction(int empId,string bank,string account) :base(empId) {
            _bank = bank;
            _account =  account;
        }

        protected override PaymentMethod GetMethod() {
            return new DirectMethod(_account,_bank);
        }
    }
}

using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.GeneralTransactions
{
    public class ChangeAddressTransaction : ChangeEmployeeTransaction{
        private string _address;

        public ChangeAddressTransaction(int empId,string address) : base(empId){
            _address = address;
        }
        protected override void Change(Employee e) {
            e.Address = _address;
        }
    }
}

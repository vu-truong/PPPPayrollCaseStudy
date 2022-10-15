using PayrollCaseStudy.CommonTypes;

namespace PayrollCaseStudy.PayrollImplementation
{
    public class SalesReceipt {
        private decimal _amount;

        public decimal Amount {
            get { return _amount; }
        }
        private Date _forDate;

        public Date Date {
            get { return _forDate; }
        }

        public SalesReceipt(decimal amount,Date forDate) {
            _amount = amount;
            _forDate = forDate;
        }

        
    }
}

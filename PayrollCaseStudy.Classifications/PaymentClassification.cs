using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.Pay;

namespace PayrollCaseStudy.Classifications
{
    public abstract class PaymentClassification {
        public abstract decimal CalculatePay(Paycheck paycheck);
            
        public bool IsInPayPeriod(Date theDate, Paycheck payCheck) {
            return Date.IsBetween(theDate,payCheck.PayPeriodStartDate,payCheck.PayPeriodEndDate);
        }
    }
}

using PayrollCaseStudy.CommonTypes;

namespace PayrollCaseStudy.PayrollDomain {
    public interface PaymentSchedule {
        bool IsPayDate(Date date);

        Date GetPayPeriodStartDate(Date payPeriod);
    }
}

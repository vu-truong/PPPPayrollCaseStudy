using PayrollCaseStudy.CommonTypes;

namespace PayrollCaseStudy.Schedules
{
    public interface PaymentSchedule {
        bool IsPayDate(Date date);

        Date GetPayPeriodStartDate(Date payPeriod);
    }
}

using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.PayrollDomain;
using System;

namespace PayrollCaseStudy.PayrollImplementation
{
    public class WeeklySchedule : PaymentSchedule{
        public bool IsPayDate(Date date) {
            if(date.DayOfWeek== DayOfWeek.Friday) {
                return true;
            }

            return false;
        }


        public Date GetPayPeriodStartDate(Date payPeriod) {
            return payPeriod.AddDays(-6);
        }
    }
}

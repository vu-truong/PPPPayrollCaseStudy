using PayrollCaseStudy.CommonTypes;
using System;

namespace PayrollCaseStudy.Schedules
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

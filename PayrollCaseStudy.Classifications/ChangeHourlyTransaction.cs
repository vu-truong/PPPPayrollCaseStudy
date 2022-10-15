using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Classifications
{
    public class ChangeHourlyTransaction : ChangeClassificationTransaction{
        private decimal _hourlyRate;

        public ChangeHourlyTransaction(int empId,decimal hourlyRate) : base(empId){
            _hourlyRate = hourlyRate;
        }

        protected override PaymentClassification GetClassification() {
            return new HourlyClassification(_hourlyRate);
        }

        protected override PaymentSchedule GetSchedule() {
            return new WeeklySchedule();
        }
    }
}

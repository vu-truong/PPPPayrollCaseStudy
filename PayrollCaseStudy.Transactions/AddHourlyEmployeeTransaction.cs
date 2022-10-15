using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.Schedules;

namespace PayrollCaseStudy.Transactions
{
    public class AddHourlyEmployeeTransaction : AddEmployeeTransaction{
        private decimal _hourlyRate;

        public AddHourlyEmployeeTransaction(int empId,string name,string address,decimal hourlyRate) : base(empId,name,address){
            _hourlyRate = hourlyRate;
        }

        protected override PaymentSchedule GetSchedule() {
            return new WeeklySchedule();
        }

        protected override PaymentClassification GetClassification() {
            return new HourlyClassification(_hourlyRate);
        }
    }
}

using PayrollCaseStudy.Employees;
using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Classifications
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

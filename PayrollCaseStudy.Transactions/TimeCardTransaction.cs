using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.CommonTypes;
using System;

namespace PayrollCaseStudy.Transactions
{
    public class TimeCardTransaction : Transaction{
        private int _empId;
        private decimal _hours;
        private Date _forDate;

        public TimeCardTransaction(Date date,decimal hours,int empId) {
            _forDate = date;
            _hours = hours;
            _empId = empId;
        }

        public void Execute() {
            var employee = PayrollDatabase.PayrollDatabase.Instance.GetEmployee(_empId);
            if(employee == null) {
                throw new Exception("No such employee");
            }

            var hourlyClassification = employee.GetClassification() as HourlyClassification;
            
            if(hourlyClassification == null) {
                throw new Exception("Tried to add timecard to non-hourly employee");
            }            

            hourlyClassification.AddTimeCard(new TimeCard(_forDate,_hours));
        }
    }
}

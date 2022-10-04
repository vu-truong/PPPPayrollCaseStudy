﻿using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.GeneralTransactions;
using PayrollCaseStudy.PayrollDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCaseStudy.GeneralTransactions {
    public class AddHourlyEmployee : AddEmployeeTransaction{
        private decimal _hourlyRate;

        public AddHourlyEmployee(int empId,string name,string address,decimal hourlyRate) : base(empId,name,address){
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
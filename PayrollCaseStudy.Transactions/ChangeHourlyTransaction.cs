﻿using PayrollCaseStudy.Classifications;
using PayrollCaseStudy.Schedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCaseStudy.Transactions {
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
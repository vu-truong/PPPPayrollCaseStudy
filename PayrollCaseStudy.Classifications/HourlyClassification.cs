﻿using PayrollCaseStudy.CommonTypes;
using PayrollCaseStudy.Pay;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PayrollCaseStudy.Classifications
{
    public class HourlyClassification : PaymentClassification{
        private decimal _hourlyRate;
        readonly List<TimeCard> _timeCards;

        public decimal HourlyRate {
            get { return _hourlyRate; }
        }

        public HourlyClassification(decimal hourlyRate) {
            _hourlyRate = hourlyRate;
            _timeCards = new List<TimeCard>();
        }


        public TimeCard GetTimeCard(Date date) {
            return _timeCards.Single(_=>_.Date==date);
        }

        public void AddTimeCard(TimeCard timeCard) {
            _timeCards.Add(timeCard);
        }

        public override decimal CalculatePay(Paycheck paycheck) {
            var perDay = _timeCards.Where(_=>IsInPayPeriod(_.Date, paycheck)).GroupBy(_=>_.Date).Select(_=>new { Date = _.Key, Hours = _.Sum(x=>x.Hours)}).ToList();

            return perDay.Sum(_=>CalculatePayForDay(_.Hours));
        }

      

        private decimal CalculatePayForDay(decimal hoursForDay) {
            var overtime = Math.Max(0M,hoursForDay-8);
            var straightTime = hoursForDay - overtime;

            return _hourlyRate * (straightTime  + 1.5M * overtime);
        }
    }
}

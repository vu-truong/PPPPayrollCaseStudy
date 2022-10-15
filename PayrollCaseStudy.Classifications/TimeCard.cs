﻿using PayrollCaseStudy.CommonTypes;

namespace PayrollCaseStudy.Classifications
{
    public class TimeCard {
        private Date _forDate;

        public Date Date {
            get { return _forDate; }
        }
        private decimal _hours;

        public decimal Hours {
            get { return _hours; }
        }

        public TimeCard(Date forDate,decimal hours) {
            _forDate = forDate;
            _hours = hours;
        }
        
    }
}
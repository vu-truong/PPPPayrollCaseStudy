﻿using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Classifications
{
    public class SalariedClassification : PaymentClassification{
        private decimal _itsSalary;

        public decimal Salary {
            get { return _itsSalary; }
        }

        public SalariedClassification(decimal itsSalary) {
            _itsSalary = itsSalary;
        }

        public override decimal CalculatePay(Paycheck paycheck) {
            return _itsSalary;
        }
    }
}
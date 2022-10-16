﻿using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.Methods
{
    public class ChangeMailTransaction : ChangeMethodTransaction{
        private string _address;

        public ChangeMailTransaction(int empId,string address) :base(empId){
            _address = address;
        }
        protected override PaymentMethod GetMethod() {
            return new MailMethod(_address);
        }
    }
}
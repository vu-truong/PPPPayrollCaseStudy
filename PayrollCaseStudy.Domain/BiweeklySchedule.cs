﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollCaseStudy.Domain {
    public class BiweeklySchedule : PaymentSchedule{
        public bool IsPayDate(Date date) {
            throw new NotImplementedException();
        }
    }
}

using PayrollCaseStudy.Pay;

namespace PayrollCaseStudy.Affiliations
{
    public class NoAffiliation : Affiliation{
        public decimal CalculateDeductions(Paycheck paycheck) {
            return 0M;
        }
    }
}

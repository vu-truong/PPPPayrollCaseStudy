using PayrollCaseStudy.Pay;

namespace PayrollCaseStudy.Affiliations
{
    public interface Affiliation {
        decimal CalculateDeductions(Paycheck paycheck);
    }
}

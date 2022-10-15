namespace PayrollCaseStudy.PayrollDomain
{
    public interface Affiliation {
        decimal CalculateDeductions(Paycheck paycheck);

        int? GetMemberId();

        void AddServiceCharge(CommonTypes.Date forDate,decimal charge);
    }
}

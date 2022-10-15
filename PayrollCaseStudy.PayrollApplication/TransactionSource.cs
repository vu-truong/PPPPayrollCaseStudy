using PayrollCaseStudy.PayrollDomain;

namespace PayrollCaseStudy.PayrollApplication
{
    public interface TransactionSource {
        Transaction Next();
    }
    
}

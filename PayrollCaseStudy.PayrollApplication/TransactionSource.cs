using PayrollCaseStudy.Transactions;

namespace PayrollCaseStudy.PayrollApplication
{
    public interface TransactionSource {
        Transaction Next();
    }
    
}

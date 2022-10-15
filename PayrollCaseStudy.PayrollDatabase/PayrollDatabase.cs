using PayrollCaseStudy.PayrollDomain;
namespace PayrollCaseStudy.PayrollDatabase
{
    public interface PayrollDatabase {
        void AddEmployee(int employeeId,Employee employee);
        void AddUnionMember(int memberId,Employee employee);
        void DeleteEmployee(int employeeId);
        System.Collections.Generic.ICollection<int> GetAllEmployeeIds();
        Employee GetEmployee(int employeeId);
        Employee GetUnionMember(int memberId);
        void RemoveUnionMember(int memberId);
    }
}

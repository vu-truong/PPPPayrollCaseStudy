using PayrollCaseStudy.PayrollDatabase;

namespace PayrollCaseStudy.Transactions
{
    public class ChangeNameTransaction : ChangeEmployeeTransaction{
        private string _newName;

        public ChangeNameTransaction(int empId,string newName)  :base(empId){
            _newName = newName;
        }

        

        protected override void Change(Employee employee) {
            employee.Name = _newName;
        }
    }
}

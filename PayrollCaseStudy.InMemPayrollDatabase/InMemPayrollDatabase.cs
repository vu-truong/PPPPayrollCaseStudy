﻿using PayrollCaseStudy.PayrollDomain;
using System.Collections.Generic;

namespace PayrollCaseStudy.InMemPayrollDatbase
{
    public class InMemPayrollDatabase : PayrollCaseStudy.PayrollDatabase.PayrollDatabase{
        readonly Dictionary<int, Employee> _itsEmployees = new Dictionary<int,Employee>();
        readonly Dictionary<int,int> _unionMemberMap = new Dictionary<int,int>();

        public Employee GetEmployee(int employeeId) {
            if(_itsEmployees.ContainsKey(employeeId)) {
                return _itsEmployees[employeeId];
            }
            
            return null;
        }
        public void AddEmployee(int employeeId, Employee employee) {
            _itsEmployees[employeeId] = employee;
        }
        public void Clear() {
            _itsEmployees.Clear();
        }

        InMemPayrollDatabase(){}

        public readonly static InMemPayrollDatabase Instance = new InMemPayrollDatabase();

        public void DeleteEmployee(int employeeId) {
            _itsEmployees.Remove(employeeId);
        }

        public void AddUnionMember(int memberId,Employee employee) {
            _unionMemberMap[memberId] = employee.EmployeeId;
        }

        public Employee GetUnionMember(int memberId) {
            if(!_unionMemberMap.ContainsKey(memberId)) {
                return null;
            }
            return GetEmployee(_unionMemberMap[memberId]);
        }

        public ICollection<int> GetAllEmployeeIds() {
            return _itsEmployees.Keys;
        }


        public void RemoveUnionMember(int memberId) {
            _unionMemberMap.Remove(memberId);
        }
    }
}

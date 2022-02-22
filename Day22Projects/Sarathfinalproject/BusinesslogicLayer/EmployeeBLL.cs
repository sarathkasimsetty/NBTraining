using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinesslogicLayer
{
    public class EmployeeBLL
    {
        public static bool GetEmployeeAdd(int empId,string empName,int empSalary,int empAge)
        {
            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);

            return result;
        }
        public static List<string> GetEmployeeById(int empId)
        {
            var result  = EmployeeDAL.GetEmployeeID(empId);
            return result;
        }
        public static List<string> GetEmployeeByName(string empName)
        {
            var result = EmployeeDAL.GetEmployeeName(empName);
            return result;
        }
        public static string[] GetALlEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }

    }
}

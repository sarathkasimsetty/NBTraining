using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class EmployeeDAL
    {
        static string filepath = "F:\\EmployeeData\\Employee.txt";

        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                string textcontent = string.Concat(empId, ",", empName, ",", empSalary, ",", empAge);

                File.AppendAllText(filepath, textcontent + Environment.NewLine);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public static List<string> GetEmployeeID(int empId)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;
            List<string> EmployeeFound = new List<string>();
            {
                foreach (string employee in allEmployees)
                {
                    var empDetails = employee.Split(',');
                    if (Convert.ToInt32(empDetails[0]) == empId)
                    {
                        isFound = true;
                       EmployeeFound.Add(employee);
                        break;
                    }

                }
                return EmployeeFound;
            }
        }
        public static List<string> GetEmployeeName(string empName)
        {   
            var allemployees = File.ReadAllLines(filepath);
            List<string> EmployeeFound = new List<string>();

             foreach (string employee in allemployees)
             {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(empName))                     
                {
                    EmployeeFound.Add(employee);
                }
             }
            return EmployeeFound;
        }

        public static string[] GetAllEmployees()
        {
            var allemployees = File.ReadAllLines(filepath);
            return allemployees;
        }
        
    }
   
}

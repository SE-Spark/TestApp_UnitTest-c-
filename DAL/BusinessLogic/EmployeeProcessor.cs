using DAL.Database;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(
            int employeeID,string firstName,
            string lastName, string email
            )
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeID,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };
            string sql = @"INSERT INTO Employee (EmployeeId,FirstName,LastName,Email)
                            VALUES(@EmployeeId,@FirstName,@LastName,@Email);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select EmployeeId,FirstName,LastName,Email from dbo.Employee;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}

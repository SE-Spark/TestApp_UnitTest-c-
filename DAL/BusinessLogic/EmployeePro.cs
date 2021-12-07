using DAL.Database;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BusinessLogic
{
    public class EmployeePro:IEmployeePro
    {
        ISqlDataAccess _db;
        public EmployeePro(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<EmployeeModel> LoadData()
        {
            string sql = "select * from Employee";

            return _db.LoadData<EmployeeModel>(sql);
        }

        public void SaveEmployee(EmployeeModel em)
        {

            string sql = @"INSERT INTO Employee (EmployeeId,FirstName,LastName,Email)
                            VALUES(@EmployeeId,@FirstName,@LastName,@Email);";
            _db.SaveData(em, sql);
        }

        public void updateEmployee(EmployeeModel em)
        {
            string sql = @"update Employee set FirstName=@FirstName,LastName=@LastName,
                            Email=@Email where EmployeeId=@EmployeeId";
            _db.UpdateData(em, sql);
        }
    }
}

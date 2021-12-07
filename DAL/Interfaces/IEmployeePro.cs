using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEmployeePro
    {
        List<EmployeeModel> LoadData();
        void SaveEmployee(EmployeeModel em);
        void updateEmployee(EmployeeModel em);
    }
}

using Autofac.Extras.Moq;
using DAL.BusinessLogic;
using DAL.Database;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DALTests.Tests
{
    public class EmpoyeeProcessorTests
    {
        [Fact]
        public void LoadData_Returns_employeedata()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<ISqlDataAccess>()
                    .Setup(x => x.LoadData<EmployeeModel>("select * from Employee"))
                    .Returns(GetSampleEmployees());

                var cls=mock.Create<EmployeePro>();
                var expected = GetSampleEmployees();

                var actual = cls.LoadData();

                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);
            }
        }

        private List<EmployeeModel> GetSampleEmployees()
        {
            var output = new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    EmployeeId=1,
                    FirstName="Samy",
                    LastName="Mun",
                    Email="mun@samy.com"
                },
                new EmployeeModel
                {
                    EmployeeId=2,
                    FirstName="Jane",
                    LastName="Mun",
                    Email="jan@samy.com"
                },
                new EmployeeModel
                {
                    EmployeeId=3,
                    FirstName="Peter",
                    LastName="Mun",
                    Email="peter@samy.com"
                }
            };
            return output;
        }
    }
}

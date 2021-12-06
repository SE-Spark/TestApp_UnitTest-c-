using DAL.Models;
using DAL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using DAL.Database;

namespace DALTests.Tests
{
    public class LoginTests
    {
        [Fact]
        public void ValidateLogin_loginShouldPass()
        {
            Login newLogins = new Login { Username = "peter", Password = "s@am!123" };
            ProcessLogins pl = new ProcessLogins(new DAL.Database.DatabaseContext());

            Assert.Equal(1, pl.Validate(newLogins));
        }

        [Fact]
        public void InsertLogin_InsertShouldPass()
        {
            using (var mock = AutoMock.GetLoose())
            {
                Login newLogins = new Login { Username = "peter", Password = "s@am!123" };
                mock.Mock<ProcessLogins>()
                    .Setup(x => x.Insert(newLogins))
                    .Returns(1);
                var cls = mock.Create<ProcessLogins>();
               var actual= cls.Insert(newLogins);

                Assert.Equal(1, actual);
            }
        }
    }
}

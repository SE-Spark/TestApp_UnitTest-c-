using DAL.Models;
using DAL.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DALTests.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void ValidateUserParams_shouldPass()
        {
            //arrange
            Login newLogins = new Login { Username = "peter", Password = "s@am!123" };
            //act
           Assert.True(LoginFuncs.ValidateUserParams(newLogins));
            
        }
        [Theory]
        [InlineData("mery","","Password")]
        [InlineData("", "keli", "Username")]
        public void ValidateUserParams_shouldFail(string username,string password,string param)
        {
            Login newLogins = new Login { Username = username, Password = password };
            var result = LoginFuncs.ValidateUserParams(newLogins);
            //assert
            Assert.False(result);
        }
    }
}

using DAL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DALTests.Tests
{
    public class MathsTests
    {
        [Fact]
        public void Add_shouldPass()
        {
            //arrange
            var expected = 8;
            //act
            var actual=Maths.Add(6, 2);
            //assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4,6,10)]
        [InlineData(14, 6, 20)]
        public void Add_shouldAlsoPass(double x,double y,double expected)
        {
            //act
            var actual = Maths.Add(x, y);
            //assert
            Assert.Equal(expected, actual);
        }

    }
}

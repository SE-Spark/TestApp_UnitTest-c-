using DAL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DALTests.Tests
{
    
    public class FizzBuzzerTests
    {
        [Fact]
        public void Input_when2Return2()
        {
            var input = 2;
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal(input.ToString(), output);
        }
        [Fact]
        public void Input_whenDiv3ReturnFizz()
        {
            var input = 3;
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal("Fizz", output);
        }
        [Fact]
        public void Input_whenDiv5ReturnBuzz()
        {
            var input = 5;
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal("Buzz", output);
        }
        [Fact]
        public void Input_whenDiv3AndDiv5ReturnFizzBuzz()
        {
            var input = 15;
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal("FizzBuzz", output);
        }
        [Theory]
        [InlineData(3,"Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(21, "Fizz")]
        [InlineData(27, "Fizz")]
        public void TInput_whenDiv3ReturnFizz(int input,string expected)
        {
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal(expected, output);
        }
        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(25, "Buzz")]
        public void TInput_whenDiv5ReturnBuzz(int input, string expected)
        {
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal(expected, output);
        }
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(75, "FizzBuzz")]
        [InlineData(105, "FizzBuzz")]
        public void TInput_whenDiv3AndDiv5ReturnFizzBuzz(int input, string expected)
        {
            string output = FizzBuzzer.GetValues(input);
            Assert.Equal(expected, output);
        }
    }
}

using System;
using Xunit;
using CalculatorDemo;
namespace XunitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            //Assemble
            Calculator calc = new Calculator();

            //Act
            int answer = calc.Add(1, 2);

            //Assert
            Assert.Equal(3, answer);
        }
        [Fact]
        public void AddTestFailing()
        {
            //Assemble
            Calculator calc = new Calculator();

            //Act
            int answer = calc.Add(4, 5);

            //Assert
            Assert.Equal(3, answer);
        }
    }
}

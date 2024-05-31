using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(2, 2, 2, 6)]
        [InlineData(4, 4, 4, 12)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {



            var calc = new Calculator();



            var actual = calc.Add(num1, num2, num3);


            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(9, 2, 7)]
        [InlineData(2, 4, -2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {



            var sub = new Calculator();


            var actual = sub.Subtract(minuend, subtrhend);


            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(10, 100, 1000)]
        [InlineData(100, 100, 10000)]




        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var mutli = new Calculator();

            //Act
            var actual = mutli.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(100, 10, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var div = new Calculator();

            //Act
            var actual = div.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}

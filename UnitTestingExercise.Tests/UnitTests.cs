using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 3, 5, 9)]
        [InlineData(2, 4, 6, 12)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var testCalc = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = testCalc.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)] //Add test data <-------
        [InlineData(5, 3, 2)]
        [InlineData(6, 1, 5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var testSub = new Calculator();

            //Act
            var actualSub = testSub.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actualSub);
        }

        [Theory]
        [InlineData(3, 2, 6)] //Add test data <-------
        [InlineData(5, 3, 15)]
        [InlineData(6, 2, 12)]
        public void MultiplyTest(int n1, int n2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var testMulti = new Calculator();

            //Act
            var actualMulti = testMulti.Multiply(n1, n2);

            //Assert
            Assert.Equal(expected, actualMulti);

        }

        [Theory]
        [InlineData(3, 3, 1)] //Add test data <-------
        [InlineData(10, 5, 2)]
        [InlineData(6, 1, 6)]
        public void DivideTest(int number1, int number2, int expected)
        {
            //Arrange

            var testDiv = new Calculator();

            //Act

            var actualDiv = testDiv.Divide(number1, number2);

            //Assert

            Assert.Equal(expected, actualDiv);

        }

    }
}

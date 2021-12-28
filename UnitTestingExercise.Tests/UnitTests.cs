using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2 ,3 ,6 )]
        
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, 50)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            var actual = test2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            int actual = test3.Devide(num1, num2); 
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            
            //Act

            //Assert
            
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}

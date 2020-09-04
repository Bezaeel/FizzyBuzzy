using FizzyBuzzy.Service.Features.FizzBuzz;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace FizzyBuzzy.Tests
{
    public class FizzBuzzServiceUnitTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        [InlineData(21)]
        public void ShouldReturnFizz(int num)
        {
            var loggerMock = new Mock<ILogger<FizzBuzz>>();
            var fizz = new FizzBuzz(loggerMock.Object);
            var result = fizz.GenerateFizzBuzz(num).Result;

            Assert.Equal("Fizz", result.Message);
        }


        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(35)]
        public void ShouldReturnBuzz(int num)
        {
            var loggerMock = new Mock<ILogger<FizzBuzz>>();
            var fizz = new FizzBuzz(loggerMock.Object);
            var result = fizz.GenerateFizzBuzz(num).Result;

            Assert.Equal("Buzz", result.Message);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        public void ShouldReturnFizzBuzz(int num)
        {
            var loggerMock = new Mock<ILogger<FizzBuzz>>();
            var fizz = new FizzBuzz(loggerMock.Object);
            var result = fizz.GenerateFizzBuzz(num).Result;

            Assert.Equal("FizzBuzz", result.Message);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(11)]
        [InlineData(19)]
        [InlineData(13)]
        public void ShouldReturnNumber(int num)
        {
            var loggerMock = new Mock<ILogger<FizzBuzz>>();
            var fizz = new FizzBuzz(loggerMock.Object);
            var result = fizz.GenerateFizzBuzz(num).Result;
            Assert.Equal(num.ToString(), result.Message);
        }
    }
}

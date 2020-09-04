using FizzyBuzzy.API.Controllers;
using FizzyBuzzy.Service.Features.FizzBuzz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzyBuzzy.Tests
{
    public class FizzBuzzControllersUnitTest
    {
        [Fact]
        public void ShouldReturn200()
        {
            var loggerMock = new Mock<ILogger<FizzBuzz>>();
            var serviceMock = new FizzBuzz(loggerMock.Object);
            var actionResult = new FizzBuzzController(serviceMock);

            var result = actionResult.FizzBuzz(3).Result as ObjectResult;
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
        }

        [Fact]
        public void ShouldReturn400()
        {
            var loggerMock = new Mock<ILogger<FizzBuzz>>();
            var serviceMock = new FizzBuzz(loggerMock.Object);
            var actionResult = new FizzBuzzController(serviceMock);

            var result = actionResult.FizzBuzz(101).Result as ObjectResult;
            Assert.Equal(StatusCodes.Status400BadRequest, result.StatusCode);
        }
    }
}

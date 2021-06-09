using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using SampleCoreApp.Controllers;


namespace SampleCoreApp.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void TestAddDefault()
        {
            var mockLogger = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mockLogger.Object);

            var result = controller.Add() as ViewResult;
            Assert.True(result.ViewData.Values.Contains("0 + 0 = 0"));
        }

        [Fact]
        public void TestAdd()
        {
            var mockLogger = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mockLogger.Object);

            var result = controller.Add(3, 8) as ViewResult;
            Assert.True(result.ViewData.Values.Contains("3 + 8 = 11"));
        }
    }
}

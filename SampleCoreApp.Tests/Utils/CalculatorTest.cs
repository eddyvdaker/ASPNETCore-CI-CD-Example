using System;
using Xunit;
using SampleCoreApp.Utils;

namespace SampleCoreApp.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(8, Calculator.Add(3, 5));
        }
    }
}

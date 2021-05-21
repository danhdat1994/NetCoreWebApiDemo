using NetCoreWebApiDemo;
using System;
using Xunit;

namespace XunitDemo
{
    public class CalculatorServiceTest
    {
        private readonly CalculatorService calculatorService;
        public CalculatorServiceTest()
        {
            calculatorService = new CalculatorService();
        }

        [Fact]
        public void Add_GiveTwoNumber_ReturnSum()
        {
            int a = 1;
            int b = 2;
            var result = calculatorService.Add(a, b);

            Assert.Equal(a + b, result);
        }

        [Fact]
        public void test()
        {
            Assert.Equal(1, 2);
        }
    }
}

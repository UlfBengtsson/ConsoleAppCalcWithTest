using System;
using Xunit;

namespace XUnitTestCalc
{
    public class UnitTest1
    {
        //https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test

        [Fact]
        public void TestAdd()
        {
            //A
            double result;

            //A
            result = ConsoleAppCalcWithTest.Program.Add(1.1, 1.1);

            //A
            Assert.Equal(2.2, result);
        }

        [Fact]
        public void TestMinus()
        {
            //A
            double result;

            //A
            result = ConsoleAppCalcWithTest.Program.Minus(1.1, 1.1);

            //A
            Assert.Equal(0.0, result);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.5, 2, 5)]
        [InlineData(100, 0.1, 10)]
        public void TestMulti(double number1, double number2, double sum)
        {
            //A
            double result;

            //A
            result = ConsoleAppCalcWithTest.Program.Multi(number1, number2);

            //A
            Assert.Equal(sum, result);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(1, 2, 0.5)]
        [InlineData(100, 0.1, 1000)]
        public void TestDiv(double number1, double number2, double sum)
        {
            //A
            double result;

            //A
            result = ConsoleAppCalcWithTest.Program.Div(number1, number2);

            //A
            Assert.Equal(sum, result);
        }

        [Fact]
        public void TestDivNaN()
        {
            //A
            double result;

            //A
            result = ConsoleAppCalcWithTest.Program.Div(0, 0);

            //A
            Assert.True(double.IsNaN(result));
        }

        [Fact]
        public void TestDivInf()
        {
            //A
            double result;

            //A
            result = ConsoleAppCalcWithTest.Program.Div(0, 1);

            //A
            Assert.True(double.IsFinite(result));
        }

        [Fact]
        public void TestArrayToString()// Because Char[].ToString() dosen´t give the value but give the name System.Char[]
        {
            char[] test = {'t', 'e', 's', 't'};

            string result = ConsoleAppCalcWithTest.Program.ArrayToString(test);

            Assert.Equal("test", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class Tests
    {
        [TestCase(1, 2, 3)]
        [TestCase(1, 2, 4)]
        public void PlusMethodTest(int firstArgument, int secondArgument, int result)
        {
            Assert.That(Plus.SummOfTwoIntegers(firstArgument, secondArgument), 
                Is.EqualTo(result), $"Неправильная сумма: {firstArgument} и {secondArgument}");
        }
    }
}
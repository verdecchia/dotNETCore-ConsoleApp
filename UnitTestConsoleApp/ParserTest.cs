using NUnit.Framework;
using System;
using ConsoleApp;

namespace UnitTestConsoleApp
{
    [TestFixture]
    public class ParserTest
    {
        [TestCase("")   ]
        [TestCase(null)]
        public void TestParse_stringEmptyOrNull_returnNull(string value)
        {
            int? result = new Parser().Parse(value);
            Assert.AreEqual(null, result);
        }

        [TestCase("1")]
        public void TestParse_stringIsValidNumber_returnInt(string value) {
            int? result = new Parser().Parse(value);
            int exptectedResult = 1;
            Assert.AreEqual(exptectedResult,result.Value);
        }

        [Test]
        public void TestParse_stringIsNotValidNumber_returnNull() {
            int? result = new Parser().Parse("any_not_valid_number");
            Assert.AreEqual(null, result);
        }

        [TestCase("1.0")]
        [TestCase("1,0")]
        public void TestParse_StringContainsPointOrComa_returnNull(string value) {
            int? result = new Parser().Parse(value);
            Assert.AreEqual(null, result);
        }
        

    }
}
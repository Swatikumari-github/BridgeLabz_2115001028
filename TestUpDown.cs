

namespace Regex
{

    using System;
    using NUnit.Framework;

    public class StringUtils
    {
        public string Reverse(string str) => new string(str.ToCharArray().Reverse().ToArray());
        public bool IsPalindrome(string str) => str == Reverse(str);
        public string ToUpperCase(string str) => str.ToUpper();
    }

    public class Calculator
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Cannot divide by zero.");
            return a / b;
        }
    }

    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            IsConnected = true;
        }

        public void Disconnect()
        {
            IsConnected = false;
        }
    }

    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;
        private Calculator _calculator;
        private DatabaseConnection _databaseConnection;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
            _calculator = new Calculator();
            _databaseConnection = new DatabaseConnection();
            _databaseConnection.Connect();
        }

        [TearDown]
        public void Teardown()
        {
            _databaseConnection.Disconnect();
        }

        [Test]
        public void Reverse_ShouldReturnReversedString()
        {
            Assert.AreEqual("dcba", _stringUtils.Reverse("abcd"));
        }

        [Test]
        public void IsPalindrome_ShouldReturnTrueForPalindrome()
        {
            Assert.IsTrue(_stringUtils.IsPalindrome("madam"));
        }

        [Test]
        public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
        {
            Assert.IsFalse(_stringUtils.IsPalindrome("hello"));
        }

        [Test]
        public void ToUpperCase_ShouldConvertToLowerCaseToUpperCase()
        {
            Assert.AreEqual("HELLO", _stringUtils.ToUpperCase("hello"));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => _calculator.Divide(10, 0));
        }

        [Test]
        public void DatabaseConnection_ShouldBeConnectedAfterSetup()
        {
            Assert.IsTrue(_databaseConnection.IsConnected);
        }

        [Test]
        public void DatabaseConnection_ShouldBeDisconnectedAfterTeardown()
        {
            Teardown();
            Assert.IsFalse(_databaseConnection.IsConnected);
        }
    }

}



namespace Regex
{
    using System;
    using System.IO;
    using System.Threading;
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

    public class NumberUtils
    {
        public bool IsEven(int number) => number % 2 == 0;
    }

    public class PerformanceTester
    {
        public void LongRunningTask()
        {
            Thread.Sleep(3000);
        }
    }

    public class FileProcessor
    {
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("File not found.");
            return File.ReadAllText(filename);
        }
    }

    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;
        private Calculator _calculator;
        private DatabaseConnection _databaseConnection;
        private NumberUtils _numberUtils;
        private PerformanceTester _performanceTester;
        private FileProcessor _fileProcessor;
        private string _testFile = "testfile.txt";

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
            _calculator = new Calculator();
            _databaseConnection = new DatabaseConnection();
            _numberUtils = new NumberUtils();
            _performanceTester = new PerformanceTester();
            _fileProcessor = new FileProcessor();
            _databaseConnection.Connect();
        }

        [TearDown]
        public void Teardown()
        {
            _databaseConnection.Disconnect();
            if (File.Exists(_testFile))
            {
                File.Delete(_testFile);
            }
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

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_ShouldReturnCorrectResult(int number, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, _numberUtils.IsEven(number));
        }

        [Test, Timeout(2000)]
        public void LongRunningTask_ShouldFailIfExceedsTimeout()
        {
            _performanceTester.LongRunningTask();
        }

        [Test]
        public void WriteToFile_ShouldCreateFileWithContent()
        {
            string content = "Hello, File!";
            _fileProcessor.WriteToFile(_testFile, content);
            Assert.IsTrue(File.Exists(_testFile));
            Assert.AreEqual(content, File.ReadAllText(_testFile));
        }

        [Test]
        public void ReadFromFile_ShouldReturnCorrectContent()
        {
            string content = "Test Content";
            File.WriteAllText(_testFile, content);
            Assert.AreEqual(content, _fileProcessor.ReadFromFile(_testFile));
        }

        [Test]
        public void ReadFromFile_ShouldThrowIOExceptionIfFileDoesNotExist()
        {
            Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile("nonexistent.txt"));
        }
    }

}

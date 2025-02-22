

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

    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
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
    }

}



using Regex;

namespace Regex
{
    using System;
    using System.Globalization;

    public class DateFormatter
    {
        public static string FormatDate(string inputDate)
        {
            try
            {
                // Parse the input date using the specified format (yyyy-MM-dd)
                DateTime date = DateTime.ParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                // Return the date in dd-MM-yyyy format
                return date.ToString("dd-MM-yyyy");
            }
            catch (FormatException)
            {
                // Return an error message if the input format is invalid
                return "Invalid date format";
            }
        }
    }

}
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class DateFormatterTests
{
    [TestMethod]
    public void TestValidDateFormat()
    {
        // Test valid input dates in yyyy-MM-dd format
        Assert.AreEqual("22-02-2025", DateFormatter.FormatDate("2025-02-22"));
        Assert.AreEqual("01-12-2021", DateFormatter.FormatDate("2021-12-01"));
    }

    [TestMethod]
    public void TestInvalidDateFormat()
    {
        // Test invalid input date formats
        Assert.AreEqual("Invalid date format", DateFormatter.FormatDate("22-02-2025"));
        Assert.AreEqual("Invalid date format", DateFormatter.FormatDate("2025/02/22"));
        Assert.AreEqual("Invalid date format", DateFormatter.FormatDate("2025-13-22"));  // Invalid month
        Assert.AreEqual("Invalid date format", DateFormatter.FormatDate("2025-02-30"));  // Invalid day
    }
}


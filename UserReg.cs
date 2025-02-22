

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class UserRegistration
    {
        public void RegisterUser(string username, string email, string password)
        {
            // Check for valid username (should not be empty and should be alphanumeric)
            if (string.IsNullOrWhiteSpace(username) || !Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                throw new ArgumentException("Invalid username. It must be non-empty and alphanumeric.");
            }

            // Check for valid email using a simple regex (basic check, more complex regex can be used)
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("Invalid email address.");
            }

            // Check for valid password (at least 6 characters)
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters long.");
            }

            // If all checks pass, assume user is registered successfully
            // You could add actual registration logic here (e.g., save to a database)
        }
    }

}
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UserRegistrationTests
{
    private UserRegistration _userRegistration;

    [TestInitialize]
    public void SetUp()
    {
        _userRegistration = new UserRegistration();
    }

    // Test for valid user registration
    [TestMethod]
    public void TestValidUserRegistration()
    {
        try
        {
            _userRegistration.RegisterUser("johnDoe123", "john.doe@example.com", "validPassword123");
            // If no exception is thrown, test passes
        }
        catch (ArgumentException)
        {
            Assert.Fail("Valid registration should not throw an exception.");
        }
    }

    // Test for invalid username
    [TestMethod]
    public void TestInvalidUsername()
    {
        // Invalid username (empty)
        Assert.ThrowsException<ArgumentException>(() =>
            _userRegistration.RegisterUser("", "valid@example.com", "ValidPass123"));

        // Invalid username (non-alphanumeric characters)
        Assert.ThrowsException<ArgumentException>(() =>
            _userRegistration.RegisterUser("invalid@username", "valid@example.com", "ValidPass123"));
    }

    // Test for invalid email
    [TestMethod]
    public void TestInvalidEmail()
    {
        // Invalid email (missing '@')
        Assert.ThrowsException<ArgumentException>(() =>
            _userRegistration.RegisterUser("validUsername", "invalidemail.com", "ValidPass123"));

        // Invalid email (missing domain)
        Assert.ThrowsException<ArgumentException>(() =>
            _userRegistration.RegisterUser("validUsername", "invalid@.com", "ValidPass123"));
    }

    // Test for invalid password
    [TestMethod]
    public void TestInvalidPassword()
    {
        // Invalid password (too short)
        Assert.ThrowsException<ArgumentException>(() =>
            _userRegistration.RegisterUser("validUsername", "valid@example.com", "short"));

        // Invalid password (empty)
        Assert.ThrowsException<ArgumentException>(() =>
            _userRegistration.RegisterUser("validUsername", "valid@example.com", ""));
    }
}


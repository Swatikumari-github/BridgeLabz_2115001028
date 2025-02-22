

namespace Regex
{

    using System;
    using System.Text.RegularExpressions;

    public class CreditCardValidator
    {
        public static bool IsValidCreditCard(string cardNumber)
        {
            // Regular expression to validate Visa or MasterCard credit card numbers
            string pattern = @"^(4\d{15}|5\d{15})$";

            // Use Regex.IsMatch to check if the input matches the credit card pattern
            return Regex.IsMatch(cardNumber, pattern);
        }
    }

    class CreditCard
    {
        static void Main()
        {
            // Example credit card numbers
            string visaCard = "4123456789012345";
            string masterCard = "5123456789012345";
            string invalidCard1 = "6123456789012345"; // Invalid (does not start with 4 or 5)
            string invalidCard2 = "412345678901234";  // Invalid (too short)

            // Validate the credit card numbers
            Console.WriteLine($"Visa card {visaCard} is valid: {CreditCardValidator.IsValidCreditCard(visaCard)}");
            Console.WriteLine($"MasterCard {masterCard} is valid: {CreditCardValidator.IsValidCreditCard(masterCard)}");
            Console.WriteLine($"Card {invalidCard1} is valid: {CreditCardValidator.IsValidCreditCard(invalidCard1)}");
            Console.WriteLine($"Card {invalidCard2} is valid: {CreditCardValidator.IsValidCreditCard(invalidCard2)}");
        }
    }

}

using System;


namespace AnnotationReflection
{
    

    
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MaxLengthAttribute : Attribute
    {
        public int MaxLength { get; }

        public MaxLengthAttribute(int maxLength)
        {
            MaxLength = maxLength;
        }
    }

   
    class User
    {
        [MaxLength(20)] // Apply the MaxLength attribute with a limit of 20 characters
        public string Username;

        // Constructor to validate the field length
        public User(string username)
        {
            var usernameField = typeof(User).GetField("Username");

            // Get the MaxLength attribute applied to the Username field
            var maxLengthAttribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(usernameField, typeof(MaxLengthAttribute));

            if (maxLengthAttribute != null && username.Length > maxLengthAttribute.MaxLength)
            {
                throw new ArgumentException($"Username cannot exceed {maxLengthAttribute.MaxLength} characters.");
            }

            Username = username;
        }
    }

    class LengthMax
    {
        static void Main()
        {
            try
            {
                // Create a User instance with a valid username
                User user1 = new User("JohnDoe123");
                Console.WriteLine($"Username: {user1.Username}");

                // Attempt to create a User instance with an invalid username (exceeding max length)
                User user2 = new User("ThisUsernameIsTooLong");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}

using System;
using System.Reflection;

namespace AnnotationReflection
{
   

    // Define the RoleAllowed attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }

        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }

    // Class that simulates access control based on user roles
    class AccountManager
    {
        [RoleAllowed("ADMIN")]  // Only ADMIN role is allowed to access this method
        public void DeleteUserAccount()
        {
            Console.WriteLine("User account deleted.");
        }

        [RoleAllowed("USER")]   // Only USER role is allowed to access this method
        public void ViewAccount()
        {
            Console.WriteLine("Viewing account details.");
        }
    }

    class Role
    {
        static void Main()
        {
            // Simulate a user role (can be "ADMIN" or "USER")
            string currentUserRole = "USER"; // Try changing this to "ADMIN" to test access

            AccountManager manager = new AccountManager();

            // Get all methods from the AccountManager class
            MethodInfo[] methods = typeof(AccountManager).GetMethods();

            foreach (var method in methods)
            {
                // Check if the method has the RoleAllowed attribute
                var roleAllowedAttribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

                if (roleAllowedAttribute != null)
                {
                    // Validate access based on the user's role
                    if (roleAllowedAttribute.Role == currentUserRole)
                    {
                        // Allow access to the method if the role matches
                        method.Invoke(manager, null);
                    }
                    else
                    {
                        // Deny access if the role doesn't match
                        Console.WriteLine($"Access Denied! You must have the {roleAllowedAttribute.Role} role to execute {method.Name}.");
                    }
                }
            }
        }
    }

}

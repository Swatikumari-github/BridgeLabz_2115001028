

namespace AnnotationReflection
{
    using System;
    using System.Reflection;

    public class Configuration
    {
        // Private static field to store the API key
        private static string API_KEY = "initial_api_key";

        // Method to display the API key
        public static void DisplayAPIKey()
        {
            Console.WriteLine($"API Key: {API_KEY}");
        }
    }

    class StaticFields
    {
        static void Main()
        {
            // Create an instance of the Configuration class (not required for static fields, but used here for context)
            Configuration config = new Configuration();

            // Get the Type object for the Configuration class
            Type configType = typeof(Configuration);

            // Use Reflection to get the private static field 'API_KEY'
            FieldInfo fieldInfo = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            if (fieldInfo != null)
            {
                // Retrieve and display the initial value of the API_KEY
                Console.WriteLine("Initial API Key:");
                config.DisplayAPIKey();

                // Modify the value of the private static field 'API_KEY' using Reflection
                fieldInfo.SetValue(null, "new_api_key_12345");

                // Retrieve and display the modified value of the API_KEY
                Console.WriteLine("Modified API Key:");
                config.DisplayAPIKey();
            }
            else
            {
                Console.WriteLine("Field 'API_KEY' not found.");
            }
        }
    }

}

namespace json
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    class Program
    {
        static void Main()
        {
            //student object
            var student = new
            {
                Name = "John Doe",
                Age = 20,
                Subjects = new string[] { "Math", "Science", "History" }
            };

            // Convert to JSON
            string json = JsonConvert.SerializeObject(student, Formatting.Indented);

            // Print JSON output
            Console.WriteLine(json);
        }
    }

}

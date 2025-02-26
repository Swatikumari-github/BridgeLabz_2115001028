

namespace json
{
    using System;
    using Newtonsoft.Json;

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Prog2
    {
        static void Main()
        {
            // Create an instance of Car
            Car myCar = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2021
            };

            // Convert to JSON
            string json = JsonConvert.SerializeObject(myCar, Formatting.Indented);

            // Print JSON output
            Console.WriteLine(json);
        }
    }

}

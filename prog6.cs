
namespace json
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    class Car1
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Prog6
    {
        static void Main()
        {
            // Create a list of Car objects
            List<Car> cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Corolla", Year = 2022 },
            new Car { Make = "Honda", Model = "Civic", Year = 2021 },
            new Car { Make = "Ford", Model = "Mustang", Year = 2020 }
        };

            // Convert list to JSON
            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);

            // Output JSON
            Console.WriteLine(json);
        }
    }

}

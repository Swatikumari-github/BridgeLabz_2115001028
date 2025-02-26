

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }


public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
 

class Prog15
    {
        static async Task Main(string[] args)
        {
            // Set up the DbContext options (assuming SQL Server)
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("YourConnectionStringHere")  // Replace with your actual connection string
                .Options;

            // Instantiate the DbContext
            using var context = new ApplicationDbContext(options);

            // Get the list of customers from the database
            var customers = await context.Customers.ToListAsync();

            // Serialize the data into JSON format
            var jsonReport = JsonConvert.SerializeObject(customers, Formatting.Indented);

            // Output the JSON report
            Console.WriteLine(jsonReport);
        }
    }

}

using CustomerApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public static class PrepDB
    {
        public static void PrepareDatabase(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CustomerContext>());
            }
            
        }

        private static void SeedData(CustomerContext customerContext)
        {
            Console.WriteLine("Applying DB Migration");
            customerContext.Database.Migrate();

            if (!customerContext.Customers.Any())
            {
                Console.WriteLine("Seeding the Database");
                customerContext.Customers.AddRange(
                    new Customer() { CustomerName = "Knight Frank Pty Ltd."}
                );
                customerContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Database is already seeded");
            }
        }
    }
}

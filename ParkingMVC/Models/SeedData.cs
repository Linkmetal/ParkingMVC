using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ParkingMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcUserContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcUserContext>>()))
            {
                // Look for any Users.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        username = "admin",
                        password = "",
                        name = "Carlos",
                        surename = "Díaz",
                        email = "linkmetal18@gmail.com",
                        phone = "662316747",
                        model = "Opel Corsa",
                        licensePlate = "123456XYZ",
                        image = "",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

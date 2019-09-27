using Microsoft.EntityFrameworkCore;
using ParkingMVC.Models;

namespace ParkingMVC.Data
{
    public class MvcUserContext : DbContext
    {
        public MvcUserContext(DbContextOptions<MvcUserContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingMVC.Models;

namespace ParkingMVC.Data
{
    public class ParkingMVCContext : DbContext
    {
        public ParkingMVCContext (DbContextOptions<ParkingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ParkingMVC.Models.User> User { get; set; }
    }
}

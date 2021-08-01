using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TollPlaza_API_Prabhdeep.Models;

namespace TollPlaza_API_Prabhdeep.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TollPrice> TollPrices { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}

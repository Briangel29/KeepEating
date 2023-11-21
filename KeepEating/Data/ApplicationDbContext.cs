using KeepEating.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepEating.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
<<<<<<< HEAD
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
=======
>>>>>>> c3c46588479ba917fe066dd902d6370d0ae73074
    }
}

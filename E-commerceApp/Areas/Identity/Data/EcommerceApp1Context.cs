using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApp1.Areas.Identity.Data;
using EcommerceApp1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp1.Data
{
    public class EcommerceApp1Context : IdentityDbContext<EcommerceApp1User>
    {
        public EcommerceApp1Context(DbContextOptions<EcommerceApp1Context> options)
            : base(options)
        {
        }

        public DbSet<Brands> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SonOfCod.Models
{
    public class SonOfCodContext : IdentityDbContext<ApplicationUser>
    {
        public SonOfCodContext(DbContextOptions options) : base(options)
        {


        }

        public SonOfCodContext()
        {
        }
        
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SonOfCod;integrated security=True");
        }
    }
}

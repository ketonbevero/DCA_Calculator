using DCA_Calculator.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCA_Calculator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<DCABag> Bags { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                 .Entity<DCABag>()
                 .Property(e => e.FIAT)
                 .HasConversion(v => v.ToString(), v => (Fiat)Enum.Parse(typeof(Fiat), v));

            builder
                .Entity<Portfolio>()
                .HasMany(d => d.Bags)
                .WithOne();

            builder
                .Entity<Transaction>()
                .HasOne(d => d.DCABag)
                .WithMany(t => t.Transactions)
                .HasForeignKey(t => t.BagId);
        }
    }
}

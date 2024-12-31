using Microsoft.EntityFrameworkCore;
using New_Project.Core.Models;
using New_Project.Infrastructure.Configuration;
using System.Collections.Generic;

namespace New_Project.Domains.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AutherConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());

        }

        public DbSet<Auther> Authers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}


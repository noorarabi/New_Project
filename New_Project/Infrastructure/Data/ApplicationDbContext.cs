using Microsoft.EntityFrameworkCore;
using New_Project.Core.Models;
using System.Collections.Generic;

namespace New_Project.Domains.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


       
        public DbSet<Auther> Authers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

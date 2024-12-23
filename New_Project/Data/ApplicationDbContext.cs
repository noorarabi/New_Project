using Microsoft.EntityFrameworkCore;
using New_Project.Models;
using System.Collections.Generic;

namespace New_Project.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

       
        public DbSet<User>User { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using New_Project.Core.Models;

namespace New_Project.Infrastructure.Configuration
{
    public class AutherConfig : IEntityTypeConfiguration<Auther>
    {
        public void Configure(EntityTypeBuilder<Auther> builder)
        {
            
            builder.ToTable("Authors");

            
            builder.HasKey(a => a.AutherId);

            
            builder.Property(a => a.AutherId)
                   .ValueGeneratedOnAdd(); 

            builder.Property(a => a.AutherName)
                   .IsRequired(true) 
                   .HasMaxLength(50); 

            builder.Property(a => a.BookNum)
                   .IsRequired(true); 
        }
    }
}

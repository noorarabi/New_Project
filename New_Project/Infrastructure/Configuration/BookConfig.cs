using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using New_Project.Core.Models;

namespace New_Project.Infrastructure.Configuration
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {

        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.ToTable("Books");


            builder.HasKey(b => b.BookId);


            builder.Property(b => b.Title)
                   .IsRequired(true)
                   .HasMaxLength(100);

            builder.Property(b => b.Description)
                   .IsRequired()
                   .HasMaxLength(300);


            builder.HasOne(b => b.Auther)
                   .WithMany()
                   .HasForeignKey(b => b.AutherId);
            builder.HasQueryFilter(b => !b.ISDeleted);

        }
       
    }
}

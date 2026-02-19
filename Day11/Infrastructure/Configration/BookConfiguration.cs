using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
    public  void Configure(EntityTypeBuilder<Book> builder)
        {
            //builder.HasKey(b=>b.BookId);

            builder.Property(b=>b.Title).IsRequired().HasMaxLength(100);
            builder.Property(b=>b.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasData(
             new Book { Id=1,Title="book1",Price=12m,AuthorId=1, CreateAt = new DateTime(2026, 2, 2), IsDeleted = false },
             new Book { Id=2,Title="book2",Price=12m,AuthorId=1, CreateAt = new DateTime(2026, 2, 2), IsDeleted = false },
             new Book { Id=3,Title="book3",Price=12m,AuthorId=1, CreateAt = new DateTime(2026, 2, 2), IsDeleted = false }

                );

        }


    }
}

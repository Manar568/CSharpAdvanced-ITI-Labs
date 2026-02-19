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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
           // builder.HasKey(a => a.AuthorId);
            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(20);
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(40);
            builder.Property(a => a.Phone).IsRequired().HasMaxLength(12);

            builder.HasData(
                
                new Author {Id=1,FirstName= "Auth1",LastName="l" ,Phone="0121155458",CreateAt=new DateTime(2026,2,2),IsDeleted=false },
                new Author {Id=2,FirstName= "Auth2",LastName="l" ,Phone="0121155458",CreateAt=new DateTime(2026,2,2),IsDeleted=false },
                new Author {Id=3,FirstName= "Auth3",LastName="l" ,Phone="0121155458",CreateAt=new DateTime(2026,2,2),IsDeleted=false }
                
                );

        }
    }
}

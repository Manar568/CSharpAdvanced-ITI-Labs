using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AuthorDtos;
using Application.Dtos.BookDtos;
using Domain.Entities;
using Mapster;

namespace Application.Mapper
{
    public  static class MapsterConfig
    {
        public static void Config()
        {
            TypeAdapterConfig<Author, GetUpdateAuthorDto>
                .NewConfig()
                .Map(des => des.Id, src => src.Id)
                .Map(des => des.FirstName, src => src.FirstName)
                ;

            TypeAdapterConfig<Author, GetAuthorWithBookDto>
                .NewConfig()
                .Map(des => des.FirstName, src => src.FirstName)
                .Map(des => des.Books, src => src.Books);


            TypeAdapterConfig<Book, GetBookByAuthorDto>
                .NewConfig()
                .Map(des => des.Id, src => src.Id)
                .Map(des => des.Title, src => src.Title)
                .Map(des => des.AuthorName, src => src.Author.FirstName);
                ;



           
        }
    }
}

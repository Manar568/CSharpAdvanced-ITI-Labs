using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.IRepositories;
using Application.Interfaces.IServices;
using Application.Services;
using Autofac;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Rebositories;

namespace PresentationLayer
{
    public static class AutofacConfiguration
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AuthorService>().As<IAuthorService>();
            builder.RegisterType<GenericRebository<Author>>().As<IGenericRebository<Author>>();

            builder.RegisterType<MyDbContext>().As<MyDbContext>();

            builder.RegisterType<BookService>().As<IBookService>();
            builder.RegisterType<GenericRebository<Book>>().As<IGenericRebository<Book>>();

            return builder.Build();

        }
    }
}

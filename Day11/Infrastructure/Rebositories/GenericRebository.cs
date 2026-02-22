using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.IRepositories;
using Domain.Entities;

namespace Infrastructure.Rebositories
{
    public class GenericRebository<T> : IGenericRebository<T> where T : BaseEntity
    {
        public MyDbContext _context;

        public GenericRebository(MyDbContext context)
        {
            _context = context;

        }

      public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

       public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
           _context.Remove(entity);
            _context.SaveChanges();
        }


        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();

        }
    }
}

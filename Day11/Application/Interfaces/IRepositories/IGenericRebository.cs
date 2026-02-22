using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.IRepositories
{
   public interface IGenericRebository<T>
    {
        public IQueryable<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);


    }
}

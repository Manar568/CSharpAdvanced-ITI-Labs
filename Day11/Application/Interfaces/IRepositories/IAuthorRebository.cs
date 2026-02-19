using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.IRepositories
{
    public interface IAuthorRebository
    {
        public List<Author> GetAllAuthors();
        public void AddAuhtor(Author author);
        public void Update(Author author);
        public void DeleteAuhtor(Author author);

      



    }
}

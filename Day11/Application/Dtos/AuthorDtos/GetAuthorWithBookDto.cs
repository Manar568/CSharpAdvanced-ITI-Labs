using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.BookDtos;

namespace Application.Dtos.AuthorDtos
{
    public class GetAuthorWithBookDto
    {
        public string FirstName { get; set; }
        public List<GetUpdatBookDto> Books { get; set; }

    }
}

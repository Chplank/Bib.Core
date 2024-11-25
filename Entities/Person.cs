using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib.Core.Entities
{
    public class Person : BaseEntity
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public List<Book> Books { get; init; }
    }
}

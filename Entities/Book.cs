using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib.Core.Entities
{
    public class Book : BaseEntity
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Author { get; init; }
        public string Summary { get; init; }
        public string ISBN { get; init; }
    }
}

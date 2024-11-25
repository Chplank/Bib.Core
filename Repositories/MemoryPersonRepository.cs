using Bib.Core.Entities;
using Bib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib.Core.Repositories
{
    // obsolete we use generic one
    [Obsolete]
    internal class MemoryPersonRepository : IRepository<Person, int>
    {
        public void Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Read(Predicate<Person> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}

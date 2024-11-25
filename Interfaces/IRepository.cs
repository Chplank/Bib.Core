using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bib.Core.Entities;

namespace Bib.Core.Interfaces
{
    public interface IRepository<TValue, TKey> where TValue : BaseEntity
    {
        public void Create(TValue entity);

        public void Update(TValue entity);

        public TValue Read(TKey id);

        public IEnumerable<TValue> Read(Predicate<TValue> filter);

        public void Delete(TValue entity);
    }
}

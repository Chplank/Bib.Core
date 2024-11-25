using Bib.Core.Entities;
using Bib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib.Core.Repositories
{
    public class Repository<TValue> : IRepository<TValue, int> where TValue : BaseEntity
    {
        private List<TValue> _books = new();
        public void Create(TValue book)
        {
            if (_books.Contains(book))
            {
                return;
            }
            _books.Add(book);
        }

        public void Delete(TValue book)
        {
            _books.Remove(book);
        }

        public TValue Read(int key) =>
            _books.FirstOrDefault(b => b.Id == key);

        public IEnumerable<TValue> Read(Predicate<TValue> filter) => _books.Where(b => filter(b));

        public void Update(TValue book)
        {
            // Book is a reference therefore no update needed in our memory repository
        }
    }
}

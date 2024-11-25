using Bib.Core.Entities;
using Bib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib.Core.Repositories
{
    [Obsolete]
    public class MemoryBookRepository : IRepository<Book, int>
    {
        private List<Book> _books = new();
        public void Create(Book book)
        {
            if (_books.Contains(book))
            {
                return;
            }
            _books.Add(book);
        }

        public void Delete(Book book)
        {
            _books.Remove(book);
        }

        public Book Read(int key) => _books.FirstOrDefault(b => b.Id == key);

        public IEnumerable<Book> Read(Predicate<Book> filter) => _books.Where(b => filter(b));

        public void Update(Book book)
        {
            // Book is a reference therefore no update needed in our memory repository
        }
    }
}

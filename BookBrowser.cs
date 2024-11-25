using Bib.Core.Entities;
using Bib.Core.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Bib.Core
{
    public class BookBrowser
    {
        private readonly IRepository<Book, int> _bookRepository;

        private readonly IRepository<Person, int> _personRepository;

        public BookBrowser(IRepository<Book, int> bookRepo, IRepository<Person, int> personRepo)
        {
            _bookRepository = bookRepo;
            _personRepository = personRepo;
        }

        public void Register(Book b)
        {
            _bookRepository.Create(b);
        }

        public void Register(Person p)
        {
            _personRepository.Create(p);
        }

        public bool IsAvailable(Book target)
        {
            return !_personRepository.Read(p => p.Books.Contains(target)).Any();
        }

        public void Lend(Book target, Person person)
        {
            if (!IsAvailable(target))
            {
                throw new InvalidOperationException("Book is not available");
            }
            person.Books.Add(target);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.Read(b => true).ToList();
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.Read(p => true).ToList();
        }
        public void GiveBack(Book target, Person? person = null)
        {
            //var book = person.Books.Any(b => target.Id == b.Id);
            if (person is not null && !person.Books.Contains(target))
            {
                throw new InvalidOperationException("The Person does not have the Book!");
            }
            if (person is not null)
            {
                person.Books.Remove(target);
            }
        }

        public void Return(Book book, Person? person = null)
        {
            var currentPerson = person ?? _personRepository.Read(p => p.Books.Contains(book)).Single();

            if (!currentPerson.Books.Contains(book))
            {
                throw new InvalidOperationException("The Person does not have the Book!");
            }

            person.Books.Remove(book);

        }


    }
}

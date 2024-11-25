using Bib.Core.Entities;
using Bib.Core.Interfaces;
using Bib.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib.Core
{
    public static class Extension
    {
        public static ServiceCollection AddBib(this ServiceCollection collection)
        {
            collection.AddScoped<IRepository<Book, int>, Repository<Book>>();
            collection.AddScoped<IRepository<Person, int>, Repository<Person>>();
            collection.AddSingleton<BookBrowser>();

            return collection;
        }
    }
}

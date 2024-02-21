using Kurs_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_2.Repositories
{
    public interface IWriteRepository<in T> where T : class, IEntity // Kontrwariancja od ogólnego do precyzyjnego
    {

        void Add(T item);

        void Remove(T item);

        void Save();
    }
}

using Kurs_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_2.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntity // kowariancja od precyzyjnego do ogólnego
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

    }
}

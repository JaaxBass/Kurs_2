using Kurs_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_2.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> 
        where T : class, IEntity
    {        
    }
}

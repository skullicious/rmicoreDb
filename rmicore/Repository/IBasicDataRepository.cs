using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Repository
{
    public interface IBasicDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
     
    }
}

using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class OccupationManager : Repository.IBasicDataRepository<Occupation>
    {

        readonly RepositoryContext _repositoryContext;

        public OccupationManager(RepositoryContext context)
        {
            _repositoryContext = context;
        }

        public IEnumerable<Occupation> GetAll()
        {

            return _repositoryContext.Occupations.ToList();
        }
  
    }
}

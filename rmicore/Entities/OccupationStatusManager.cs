using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class OccupationStatusManager : Repository.IBasicDataRepository<OccupationStatus>
    {

        readonly RepositoryContext _repositoryContext;

        public OccupationStatusManager(RepositoryContext context)
        {
            _repositoryContext = context;
        }

        public IEnumerable<OccupationStatus> GetAll()
        {

            return _repositoryContext.OccupationStatus.ToList();
        }
  
    }
}

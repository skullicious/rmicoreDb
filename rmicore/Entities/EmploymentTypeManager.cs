using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class EmploymentTypeManager : Repository.IBasicDataRepository<EmploymentType>
    {

        readonly RepositoryContext _repositoryContext;

        public EmploymentTypeManager(RepositoryContext context)
        {
            _repositoryContext = context;
        }

        public IEnumerable<EmploymentType> GetAll()
        {

            return _repositoryContext.EmploymentTypes.ToList();
        }
  
    }
}

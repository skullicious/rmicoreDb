using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class TitleManager : Repository.IBasicDataRepository<Title>
    {

        readonly RepositoryContext _repositoryContext;

        public TitleManager(RepositoryContext context)
        {
            _repositoryContext = context;
        }

        public IEnumerable<Title> GetAll()
        {

            return _repositoryContext.Titles.ToList();
        }
  
    }
}

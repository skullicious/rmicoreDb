using rmicore.Entities;
using rmicore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Repository
{
    public class DataRepository : IDataRepository
    {

        private readonly RepositoryContext _db;

        public DataRepository(RepositoryContext connection)
        {
            _db = connection;
        }

        public List <Title> GetAllTitles()
        {
            return _db.Titles.ToList();
        }
    }
}

using Microsoft.AspNetCore.Connections;
using rmicore.Entities;
using rmicore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Repository
{
    public class RiderRepository : IRiderRepository
    {

        private readonly RepositoryContext _db;
        public RiderRepository(RepositoryContext connection)
        {
            _db = connection;
        }

        public Rider GetRiderById(int riderId)
        {
            return _db.Rider.Find(riderId);
        }

    }
}

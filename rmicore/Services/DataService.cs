using rmicore.Entities;
using rmicore.Interface;
using rmicore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Services
{
    public class DataService : IDataService
    {


        private readonly IDataRepository _dataRepository;


        public DataService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public List<Title> GetAllTitles()
        {
            return _dataRepository.GetAllTitles();
        }
    }
}

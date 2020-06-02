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

        public List<Occupation> GetAllOccupations()
        {
            return _db.Occupations.ToList();
        }

        public List<OccupationStatus> GetAllOccupationStatuses()
        {
            return _db.OccupationStatus.ToList();
        }

        public List<EmploymentType> GetAllEmploymentTypes()
        {
            return _db.EmploymentTypes.ToList();
        }

        public List<VehicleUse> GetAllVehicleUses()
        {
            return _db.VehicleUses.ToList();
        }

        public List<LicenseType> GetAllLicenseTypes()
        {
            return _db.LicenseTypes.ToList();
        }

        public List<CycleUse> GetAllCycleUses()
        {
            return _db.CycleUses.ToList();
        }
    }
}

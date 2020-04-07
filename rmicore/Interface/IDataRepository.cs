using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Interface
{
    public interface IDataRepository
    {
       public List<Title> GetAllTitles();

        public List<Occupation> GetAllOccupations();

        public List<EmploymentType> GetAllEmploymentTypes();

        public List<OccupationStatus> GetAllOccupationStatuses();

        public List<VehicleUse> GetAllVehicleUses();

        public List<LicenseType> GetAllLicenseTypes();
    }
}

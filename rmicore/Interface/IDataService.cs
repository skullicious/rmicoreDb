using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Interface
{
    public interface IDataService
    {
        public List<SimpleReactObjectViewModel> GetAllTitles();

        public List<SimpleReactObjectViewModel> GetAllOccupations();

        public List<SimpleReactObjectViewModel> GetAllOccupationStatuses();

        public List<SimpleReactObjectViewModel> GetAllEmploymentTypes();

        public List<SimpleReactObjectViewModel> GetAllLicenseTypes();

        public List<SimpleReactObjectViewModel> GetAllVehicleUses();
    }
}

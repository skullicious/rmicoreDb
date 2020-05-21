using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Interface
{
    public interface IRiderRepository
    {
        User GetRiderById(int riderId);
        bool AddIndividualToDatabase(Individual individual);

        Individual GetIndividualById(int riderId);

        bool EditObjectInDatabase(object dbValues, object table);
    }
}

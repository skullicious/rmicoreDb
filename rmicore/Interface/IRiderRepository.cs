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

        bool AddAddressToDatabase(Address address);

        bool AddEmailToDatabase(Email email);

        Individual GetIndividualById(int riderId);

        Email GetEmailById(int riderId);

        Address GetAddressById(int riderId);            

        bool EditObjectInDatabase(object dbValues, object table);
    }
}

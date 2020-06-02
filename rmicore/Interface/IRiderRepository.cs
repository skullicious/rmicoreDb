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

        bool AddPhoneNumberToDatabase(PhoneNumber phoneNumber);

        bool AddOccupationToDatabase(RiderOccupation occupation);

        bool AddRiderCycleUseToDatabase(RiderCycleUse cycleUse);

        Individual GetIndividualById(int riderId);

        Email GetEmailById(int riderId);

        Address GetAddressById(int riderId);

        PhoneNumber GetPhoneNumberById(int riderId);

        RiderOccupation GetOccupationById(int riderId);

        RiderCycleUse GetCycleUseById(int riderId);

        bool EditObjectInDatabase(object dbValues, object table);
    }
}

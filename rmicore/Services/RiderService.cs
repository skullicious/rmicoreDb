using rmicore.Dtos;
using rmicore.Entities;
using rmicore.Interface;
using rmicore.Repository;
using rmicore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Services
{
    public class RiderService : IRiderService
    {
        private readonly IRiderRepository _riderRepository;

        public RiderService(IRiderRepository riderRepository, IDataService dataService)
        {
            _riderRepository = riderRepository;
       

        }

        public User GetRiderById(int riderId)
        {
            return  _riderRepository.GetRiderById(riderId);
        }



        public RiderViewModel PopulateRiderViewModel(User rider, RiderViewModel viewModel)
        {
           
            viewModel.Id = rider.Id;
            viewModel.individual = GetIndividualById(rider.Id);
            viewModel.contact.address = GetAddressById(rider.Id);
            viewModel.contact.Email = GetEmailById(rider.Id);
            viewModel.contact.phoneNumber = GetPhoneNumberById(rider.Id);
            viewModel.occupation = GetOccupationById(rider.Id);
            viewModel.cycleUse = GetCycleUseById(rider.Id);
                        
            
            //viewModel.Person.Status = await GetStatusById(person.Id, new ProposerStatus()) ?? new ProposerStatus() { Person = person };
            //viewModel.Person.LicenceUse = await GetLicenceById(person.Id, new RiderLicence()) ?? new RiderLicence() { Person = person };
            //viewModel.OccupationVM = await PopulateOccupationViewModel(person.Id);
            //viewModel.ContactVM = await PopulateContactViewModel(person.Id, person);
            //if (viewModel.ContactVM.HomeAddress.ConfirmedAddress != null)
            //    viewModel.AddressSearched = true;
            return viewModel;
        }


        public bool FullPagePost(riderDto riderDto)
        {
            bool individualReturn = AddOrUpdateIndividualDetails(riderDto);
            bool addressReturn = AddOrUpdateAddress(riderDto);
            bool emailReturn = AddOrUpdateEmail(riderDto);
            bool phoneNumberReturn = AddOrUpdatePhoneNumber(riderDto);
            bool occupationReturn = AddOrUpdateOccupation(riderDto);
            bool cycleUseReturn = AddOrUpdateCycleUse(riderDto);
            //bool statusReturn = AddOrUpdateStatusDetails(viewModel);      
            //bool vehicleUseReturn = AddOrUpdateVehicleUseDetails(viewModel); 

            bool blReturn = individualReturn && addressReturn && emailReturn && phoneNumberReturn && occupationReturn && cycleUseReturn;
            //bool blReturn = (licenceReturn && statusReturn && contactReturn && indivReturn);
            return blReturn;
        }

        private bool AddOrUpdateIndividualDetails(riderDto riderDto)
        {
            bool blReturn = true;

            try
            {

                Individual individual = riderDto.individual;
                individual.UserId = riderDto.Id;

                //Person comes in here?
                //Person ID is set

                //Try validating on a per class basis here
                //    blReturn =  _riderRepository.AddIndividualToDatabase(individual);
                var dbValue = GetIndividualById(riderDto.Id);

                blReturn = (dbValue == null) ? _riderRepository.AddIndividualToDatabase(individual) : _riderRepository.EditObjectInDatabase(dbValue, individual);

            }

            catch (Exception ex)
            {

            }

            return blReturn;
        }

        private bool AddOrUpdateOccupation(riderDto riderDto)
        {
            bool blReturn = true;

            try
            {

                RiderOccupation occupation = riderDto.occupation;
                occupation.UserId = riderDto.Id;

              
                //Try validating on a per class basis here
                //    blReturn =  _riderRepository.AddIndividualToDatabase(individual);
                var dbValue = GetOccupationById(riderDto.Id);

                blReturn = (dbValue == null) ? _riderRepository.AddOccupationToDatabase(occupation) : _riderRepository.EditObjectInDatabase(dbValue, occupation);

            }

            catch (Exception ex)
            {

            }

            return blReturn;
        }

        private bool AddOrUpdatePhoneNumber(riderDto riderDto)
        {
            bool blReturn = true;

            try
            {
                PhoneNumber phoneNumber = riderDto.phoneNumber;

                phoneNumber.UserId = riderDto.Id;

                //var riderId = riderDto.Id;

                var dbValue = GetPhoneNumberById(riderDto.Id);

                blReturn = (dbValue == null) ? _riderRepository.AddPhoneNumberToDatabase(phoneNumber) : _riderRepository.EditObjectInDatabase(dbValue, phoneNumber);

            }

            catch (Exception ex)
            {

            }

            return blReturn;
        }

        private bool AddOrUpdateEmail(riderDto riderDto)
        {
            bool blReturn = true;

            try
            {
                Email email = riderDto.email;
                email.UserId = riderDto.Id;

                var dbValue = GetEmailById(riderDto.Id);

                blReturn = (dbValue == null) ? _riderRepository.AddEmailToDatabase(email) : _riderRepository.EditObjectInDatabase(dbValue, email);

            }

            catch (Exception ex)
            {

            }

            return blReturn;
        }

        private bool AddOrUpdateCycleUse(riderDto riderDto)
        {
            bool blReturn = true;

            try
            {
                RiderCycleUse cycleUse = riderDto.cycleUse;
                cycleUse.UserId = riderDto.Id;

                var dbValue = GetCycleUseById(riderDto.Id);

                blReturn = (dbValue == null) ? _riderRepository.AddRiderCycleUseToDatabase(cycleUse) : _riderRepository.EditObjectInDatabase(dbValue, cycleUse);

            }

            catch (Exception ex)
            {

            }

            return blReturn;
        }



        private bool AddOrUpdateAddress(riderDto riderDto)
        {
            bool blReturn = true;

            try
            {
                Address address = riderDto.address;
                address.UserId = riderDto.Id;

                var dbValue = GetAddressById(riderDto.Id);

                blReturn = (dbValue == null) ? _riderRepository.AddAddressToDatabase(address) : _riderRepository.EditObjectInDatabase(dbValue, address);

            }
            catch (Exception ex)
            {

            }

            return blReturn;

        }


        private PhoneNumber GetPhoneNumberById(int riderId)
        {
            return _riderRepository.GetPhoneNumberById(riderId);

        }
        private Email GetEmailById(int riderId)
        {
            return _riderRepository.GetEmailById(riderId);

        }

        private Address GetAddressById(int riderId)
        {
            return _riderRepository.GetAddressById(riderId);
        }

        private Individual GetIndividualById(int riderId)
        {
            return _riderRepository.GetIndividualById(riderId);
        }

        private RiderOccupation GetOccupationById(int riderId)
        {
            return _riderRepository.GetOccupationById(riderId);
        }

        private RiderCycleUse GetCycleUseById(int riderId)
        {
            return _riderRepository.GetCycleUseById(riderId);
        }


    }
}

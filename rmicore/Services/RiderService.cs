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
        public RiderService(IRiderRepository riderRepository)
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
            //bool statusReturn = AddOrUpdateStatusDetails(viewModel);
            //bool occupationReturn = AddOrUpdateOccupationDetails(viewModel);
            //bool vehicleUseReturn = AddOrUpdateVehicleUseDetails(viewModel); 

            bool blReturn = individualReturn;
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


        private Individual GetIndividualById(int riderId)
        {

            return _riderRepository.GetIndividualById(riderId);
        }

    }
}

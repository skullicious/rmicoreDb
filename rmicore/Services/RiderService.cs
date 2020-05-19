﻿using rmicore.Entities;
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

        public Rider GetRiderById(int riderId)
        {
            return  _riderRepository.GetRiderById(riderId);
        }



        public RiderViewModel PopulateRiderViewModel(Rider rider, RiderViewModel viewModel)
        {
            viewModel.rider = rider;
            viewModel.Id = rider.Id;
            //viewModel.Person.Status = await GetStatusById(person.Id, new ProposerStatus()) ?? new ProposerStatus() { Person = person };
            //viewModel.Person.LicenceUse = await GetLicenceById(person.Id, new RiderLicence()) ?? new RiderLicence() { Person = person };
            //viewModel.OccupationVM = await PopulateOccupationViewModel(person.Id);
            //viewModel.ContactVM = await PopulateContactViewModel(person.Id, person);
            //if (viewModel.ContactVM.HomeAddress.ConfirmedAddress != null)
            //    viewModel.AddressSearched = true;
            return viewModel;
        }


    }
}

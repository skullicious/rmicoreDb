using AutoMapper;
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
    public class DataService : IDataService
    {

        private readonly IMapper _mapper;

        private readonly IDataRepository _dataRepository;


        public DataService(IMapper mapper, IDataRepository dataRepository)
        {
            _mapper = mapper;
            _dataRepository = dataRepository;
        }

        
        public riderDto MapViewModelToDto(RiderViewModel riderViewModel)
        {
            

            var result = _mapper.Map<RiderViewModel, riderDto>(riderViewModel);

            return result;
        }

        public List<SimpleReactObjectViewModel> GetAllTitles()
        {

            var titles = _dataRepository.GetAllTitles();

            var result = _mapper.Map<List<SimpleReactObjectViewModel>>(titles);

            return result;
        }

        public List<SimpleReactObjectViewModel> GetAllOccupations()
        {
            var occupations = _dataRepository.GetAllOccupations();

            var result = _mapper.Map<List<SimpleReactObjectViewModel>>(occupations);

            return result;
        }

        public List<SimpleReactObjectViewModel> GetAllOccupationStatuses()
        {

            var occupationstatus = _dataRepository.GetAllOccupationStatuses();

            var result = _mapper.Map<List<SimpleReactObjectViewModel>>(occupationstatus);

            return result;
        }

        public List<SimpleReactObjectViewModel> GetAllEmploymentTypes()
        {

            var employmenttypes = _dataRepository.GetAllEmploymentTypes();

            var result = _mapper.Map<List<SimpleReactObjectViewModel>>(employmenttypes);

            return result;
        }

        public List<SimpleReactObjectViewModel> GetAllLicenseTypes()
        {

            var licensetypes = _dataRepository.GetAllLicenseTypes();

            var result = _mapper.Map<List<SimpleReactObjectViewModel>>(licensetypes);

            return result;
        }

        public List<SimpleReactObjectViewModel> GetAllVehicleUses()
        {

            var vehicleuses = _dataRepository.GetAllVehicleUses();

            var result = _mapper.Map<List<SimpleReactObjectViewModel>>(vehicleuses);

            return result;
        }

    }
}

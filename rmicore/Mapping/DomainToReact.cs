using AutoMapper;
using Microsoft.AspNetCore.Identity;
using rmicore.Dtos;
using rmicore.Entities;
using rmicore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rmicore.Mapping
{
    public class DomainToReact: Profile
    {

        public DomainToReact()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();


            CreateMap<RiderViewModel, riderDto>()
                .ForPath(dest => dest.individual.individual_firstName, opt =>
                 opt.MapFrom(src => src.individual_firstName))
                 .ForPath(dest => dest.individual.individual_lastName, opt =>
                 opt.MapFrom(src => src.individual_lastName))
                  .ForPath(dest => dest.individual.individual_title, opt =>
                 opt.MapFrom(src => src.individual_title));                



            CreateMap<Title, SimpleReactObjectViewModel>()
                .ForMember(dest => dest._id, opt =>
                 opt.MapFrom(src => src.TitleId));

            CreateMap<Occupation, SimpleReactObjectViewModel>()
                .ForMember(dest => dest._id, opt =>
                 opt.MapFrom(src => src.OccupationId));

            CreateMap<OccupationStatus, SimpleReactObjectViewModel>()
               .ForMember(dest => dest._id, opt =>
                opt.MapFrom(src => src.OccupationStatusId));

            CreateMap<EmploymentType, SimpleReactObjectViewModel>()
              .ForMember(dest => dest._id, opt =>
               opt.MapFrom(src => src.EmploymentTypeId));

            CreateMap<LicenseType, SimpleReactObjectViewModel>()
              .ForMember(dest => dest._id, opt =>
               opt.MapFrom(src => src.LicenseTypeId));

            CreateMap<VehicleUse, SimpleReactObjectViewModel>()
              .ForMember(dest => dest._id, opt =>
               opt.MapFrom(src => src.VehicleUseId));
                                
        }


    }
}

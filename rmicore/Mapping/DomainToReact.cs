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
                .ForPath(dest => dest.individual.Id, opt =>
                 opt.MapFrom(src => src.individual.Id))
                .ForPath(dest => dest.individual.firstName, opt =>
                 opt.MapFrom(src => src.individual.firstName))
                 .ForPath(dest => dest.individual.lastName, opt =>
                 opt.MapFrom(src => src.individual.lastName))
                  .ForPath(dest => dest.individual.title, opt =>
                 opt.MapFrom(src => src.individual.title))
                  .ForPath(dest => dest.address.PostCode, opt =>
                 opt.MapFrom(src => src.contact.address.PostCode))
                    .ForPath(dest => dest.email.EmailAddress, opt =>
                 opt.MapFrom(src => src.contact.Email.EmailAddress));
            ;





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

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
                  .ForPath(dest => dest.individual.dateOfBirth, opt =>
                 opt.MapFrom(src => src.individual.dateOfBirth))
                  .ForPath(dest => dest.address.PostCode, opt =>
                 opt.MapFrom(src => src.contact.address.PostCode))
                     .ForPath(dest => dest.address.AddressLine1, opt =>
                 opt.MapFrom(src => src.contact.address.AddressLine1))
                     .ForPath(dest => dest.address.AddressLine2, opt =>
                 opt.MapFrom(src => src.contact.address.AddressLine2))
                    .ForPath(dest => dest.address.AddressLine3, opt =>
                 opt.MapFrom(src => src.contact.address.AddressLine3))
                     .ForPath(dest => dest.address.AddressLine4, opt =>
                 opt.MapFrom(src => src.contact.address.AddressLine4))
                    .ForPath(dest => dest.address.AddressLine5, opt =>
                 opt.MapFrom(src => src.contact.address.AddressLine5))
                    .ForPath(dest => dest.address.Id, opt =>
                 opt.MapFrom(src => src.contact.address.Id))
                    .ForPath(dest => dest.address.ConfirmedAddress, opt =>
                 opt.MapFrom(src => src.contact.address.ConfirmedAddress))
                    .ForPath(dest => dest.email.EmailAddress, opt =>
                 opt.MapFrom(src => src.contact.Email.EmailAddress))
                    .ForPath(dest => dest.email.EmailId, opt =>
                 opt.MapFrom(src => src.contact.Email.EmailId))
                     .ForPath(dest => dest.phoneNumber.Id, opt =>
                 opt.MapFrom(src => src.contact.phoneNumber.Id))
                     .ForPath(dest => dest.phoneNumber.Number, opt =>
                 opt.MapFrom(src => src.contact.phoneNumber.Number))
                    .ForPath(dest => dest.occupation.Id, opt =>
                 opt.MapFrom(src => src.occupation.Id))
                    .ForPath(dest => dest.occupation.occupation, opt =>
                 opt.MapFrom(src => src.occupation.occupation))
                    .ForPath(dest => dest.occupation.occupationStatus, opt =>
                 opt.MapFrom(src => src.occupation.occupationStatus))
                    .ForPath(dest => dest.occupation.employmentType, opt =>
                 opt.MapFrom(src => src.occupation.employmentType))
                    .ForPath(dest => dest.occupation.partTime, opt =>
                 opt.MapFrom(src => src.occupation.partTime))
                    .ForPath(dest => dest.occupation.partTime, opt =>
                 opt.MapFrom(src => src.occupation.partTime))
                    .ForPath(dest => dest.cycleUse.Id, opt =>
                 opt.MapFrom(src => src.cycleUse.Id))
                    .ForPath(dest => dest.cycleUse.cycleUse, opt =>
                 opt.MapFrom(src => src.cycleUse.cycleUse))
                   .ForPath(dest => dest.cycleUse.isCommuting, opt =>
                 opt.MapFrom(src => src.cycleUse.isCommuting))
                   .ForPath(dest => dest.cycleUse.licenseType, opt =>
                 opt.MapFrom(src => src.cycleUse.licenseType))
                    .ForPath(dest => dest.cycleUse.motoringQualification, opt =>
                 opt.MapFrom(src => src.cycleUse.motoringQualification))
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

            CreateMap<CycleUse, SimpleReactObjectViewModel>()
              .ForMember(dest => dest._id, opt =>
               opt.MapFrom(src => src.CycleUseId));

        }


    }
}

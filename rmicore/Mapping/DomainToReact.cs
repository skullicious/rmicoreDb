using AutoMapper;
using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace rmicore.Mapping
{
    public class DomainToReact: Profile
    {

        public DomainToReact()
        {
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


        }


    }
}

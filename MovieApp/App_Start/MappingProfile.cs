using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieApp.Dtos;
using MovieApp.Models;
using MembershipTypeDto = MovieApp.Dtos.MembershipTypeDto;

namespace MovieApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Movie,MovieDto>();
            Mapper.CreateMap<MovieDto,Movie>().ForMember(c => c.Id,opt => opt.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();
        }
    }
}
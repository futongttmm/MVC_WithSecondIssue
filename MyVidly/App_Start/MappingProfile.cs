using AutoMapper;
using MyVidly.Dtos;
using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyVidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //when we call this create map Matha automapper uses reflection 
            //to scan these types and finds their properties and maps them based on their name
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<GenreDto, Genre>();
            
        }
    }
}
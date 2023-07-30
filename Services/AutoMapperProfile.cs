using AutoMapper;
using CityApi.Models;
using Database.Model;
using Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<City, CityDto>().ForMember(el => el.Region, w => w.MapFrom(src => src.Country));
        }
    }
}

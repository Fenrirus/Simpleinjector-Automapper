using AutoMapper;
using AutoMapping.Models;
using AutoMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapping.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
        }
    }
}
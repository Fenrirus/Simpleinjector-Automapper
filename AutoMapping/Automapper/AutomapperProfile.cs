using AutoMapper;
using AutoMapping.Models;

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
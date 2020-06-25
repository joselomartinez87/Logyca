using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class EnterprisesProfile : Profile
    {
        public EnterprisesProfile()
        {
            //Source -> Target
            CreateMap<Enterprise, EnterpriseReadDto>();
            CreateMap<EnterpriseCreateDto, Enterprise>();
            CreateMap<EnterpriseUpdateDto, Enterprise>();
            CreateMap<Enterprise, EnterpriseUpdateDto>();
            
        }
    }
}
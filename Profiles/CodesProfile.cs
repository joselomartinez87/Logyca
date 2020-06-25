using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class CodesProfile : Profile
    {
        public CodesProfile()
        {
            //Source -> Target
            CreateMap<Code, CodeReadDto>();
            CreateMap<CodeCreateDto, Code>();
            CreateMap<CodeUpdateDto, Code>();
            CreateMap<Code, CodeUpdateDto>();
            
        }
    }
}
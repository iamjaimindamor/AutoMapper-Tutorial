using AutoMapper;
using AutoMapperTutorial.Models;
using AutoMapperTutorial.Models.DTOs;

namespace AutoMapperTutorial.MapperProfile
{
    public class SuperHeroProfile : Profile
    {
        public SuperHeroProfile()
        {
            CreateMap<SuperHeroModel, HeroDTOs>();
            CreateMap<HeroDTOs, SuperHeroModel>();
        }
    }
}

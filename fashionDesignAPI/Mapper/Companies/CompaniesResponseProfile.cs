using AutoMapper;
using fashionDesignAPI.Dto.Companies.Response;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Mapper.Companies
{
    public class CompaniesResponseProfile : Profile
    {
        public CompaniesResponseProfile()
        {
            CreateMap<Company, CompaniesResponse>()
                .ForMember(dest => dest.Id, src => src.MapFrom(s => s.Id))
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.Name))
                .ForMember(dest => dest.Cnpj, src => src.MapFrom(s => s.Cnpj))
                .ForMember(dest => dest.Manager, src => src.MapFrom(s => s.Manager))
                .ForMember(dest => dest.Email, src => src.MapFrom(s => s.Email))
                .ReverseMap();
        }
    }
}

using AutoMapper;
using fashionDesignAPI.Dto.Companies.Request;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Mapper.Companies
{
    public class PostCompaniesProfile : Profile
    {
        public PostCompaniesProfile()
        {
            CreateMap<PostCompanies, Company>().ReverseMap();
        }
    }
}
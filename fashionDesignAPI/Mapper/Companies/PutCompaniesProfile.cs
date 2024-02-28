using AutoMapper;
using fashionDesignAPI.Dto.Companies.Request;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Mapper.Companies
{
    public class PutCompaniesProfile : Profile
    {
        public PutCompaniesProfile()
        {
            CreateMap<PutCompanies, Company>().ReverseMap();
        }
    }
}
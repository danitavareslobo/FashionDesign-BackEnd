using AutoMapper;
using fashionDesignAPI.Dto.CompaniesSetup.Request;
using fashionDesignAPI.Dto.CompaniesSetup.Response;
using fashionDesignAPI.Exceptions;
using fashionDesignAPI.Interfaces.Repositories;
using fashionDesignAPI.Interfaces.Services;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Services
{
    public class CompaniesSetupService : ICompaniesSetupService
    {
        private readonly IMapper _mapper;
        private readonly ICompaniesSetupRepository _repository;

        public CompaniesSetupService(IMapper mapper, ICompaniesSetupRepository companySetupRepository)
        {
            _mapper = mapper;
            _repository = companySetupRepository;
        }

        public async Task<bool?> CreateAsync(CompaniesSetupRequest companySetup, int companyId)
        {
            try
            {
                CompanySetup companySetupCreate = new CompanySetup
                {
                    Theme = companySetup.Theme,
                    Logo = companySetup.Logo,
                    CompanySetupId = companyId
                };
                var companySetupMapper = _mapper.Map<CompanySetup>(companySetup);

                return await _repository.CreateAsync(companySetupMapper);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<ThemeResponse> GetColorMode(int companyId)
        {
            var mode = await _repository.GetColorModeAsync(companyId);

            return mode;
        }

        public async Task<LogoResponse> GetImgCompany(int companyId)
        {
            var logo = await _repository.GetImgCompanyAsync(companyId);

            return logo;
        }

        public async Task<bool> UpdateCompanySetup(CompaniesSetupRequest companySetup, int companyId)
        {
            var response = await _repository.UpdateAsync(companySetup, companyId);
            if (!response)
                throw new BadRequestException("Não foi atualizar as configurações gerais.");

            return response;
        }
    }
}

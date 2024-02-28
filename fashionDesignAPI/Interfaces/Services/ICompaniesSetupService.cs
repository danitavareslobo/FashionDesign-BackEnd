using fashionDesignAPI.Dto.CompaniesSetup.Request;
using fashionDesignAPI.Dto.CompaniesSetup.Response;

namespace fashionDesignAPI.Interfaces.Services
{
    public interface ICompaniesSetupService
    {
        Task<bool?> CreateAsync(CompaniesSetupRequest companySetup, int companyId);
        Task<bool> UpdateCompanySetup(CompaniesSetupRequest companySetup, int companyId);
        Task<ThemeResponse> GetColorMode(int companyId);
        Task<LogoResponse> GetImgCompany(int companyId);
    }
}

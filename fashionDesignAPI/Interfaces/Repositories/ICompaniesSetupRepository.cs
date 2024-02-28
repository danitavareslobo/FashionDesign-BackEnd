using fashionDesignAPI.Dto.CompaniesSetup.Request;
using fashionDesignAPI.Dto.CompaniesSetup.Response;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Interfaces.Repositories
{
    public interface ICompaniesSetupRepository
    {
        Task<bool> CreateAsync(CompanySetup companySetup);
        Task<bool> UpdateAsync(CompaniesSetupRequest companySetupRequest, int companyId);
        Task<ThemeResponse> GetColorModeAsync(int companyId);
        Task<LogoResponse> GetImgCompanyAsync(int companyId);
        Task<CompanySetup> GetSetupByCompanyIdAsync(int companyId);
    }
}

using fashionDesignAPI.Dto.Companies.Request;
using fashionDesignAPI.Dto.Companies.Response;

namespace fashionDesignAPI.Interfaces.Services
{
    public interface ICompaniesService
    {
        Task<CompaniesResponse> CreateAsync(PostCompanies company);
        Task<CompaniesResponse> UpdateAsync(int id, PutCompanies company);
        Task<bool> DeleteAsync(int id);
        Task<CompaniesResponse> GetByIdAsync(int id);
    }
}

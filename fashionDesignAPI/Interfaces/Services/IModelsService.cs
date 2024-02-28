using fashionDesignAPI.Dto.Models.Request;
using fashionDesignAPI.Dto.Models.Response;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Interfaces.Services
{
    public interface IModelsService
    {
        Task<int> CreateAsync(PostModels model, int companyId);
        Task<bool> UpdateAsync(PutModels modelDto, int id, int companyId);
        Task<bool> DeleteAsync(int id, int companyId);
        Task<Model> GetByIdAsync(int id, int companyId);
        Task<List<ModelResponse>> GetAllAsync(int companyId);
    }
}

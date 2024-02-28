using fashionDesignAPI.Models.Enums;

namespace fashionDesignAPI.Dto.CompaniesSetup.Request
{
    public class CompaniesSetupRequest
    {
        public ThemeEnum Theme { get; set; }
        public string Logo { get; set; }
    }
}

using fashionDesignAPI.Models.Enums;

namespace fashionDesignAPI.Dto.CompaniesSetup.Response
{
    public class ThemeResponse
    {
        public ThemeEnum Theme { get; set; }

        public ThemeResponse(ThemeEnum theme)
        {
            Theme = theme;
        }
    }
}

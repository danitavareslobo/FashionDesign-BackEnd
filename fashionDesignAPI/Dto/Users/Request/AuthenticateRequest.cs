using System.ComponentModel.DataAnnotations;

namespace fashionDesignAPI.Dto.Users.Request
{
    public class AuthenticateRequest
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public bool IsValid => Validate();

        private bool Validate()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }
    }
}

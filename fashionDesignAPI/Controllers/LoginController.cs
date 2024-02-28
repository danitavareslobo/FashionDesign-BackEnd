using fashionDesignAPI.Attributes;
using fashionDesignAPI.Dto.Users.Request;
using fashionDesignAPI.Interfaces.Services;

using Microsoft.AspNetCore.Mvc;

namespace fashionDesignAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUsersService _service;

        public LoginController(IUsersService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GenerateJwtToken(AuthenticateRequest request)
        {

            return Ok(new { token = await _service.GenerateJwtToken(request) });
        }
    }
}

using designFashion.Dto.Users.Response;
using fashionDesignAPI.Attributes;
using fashionDesignAPI.Dto.Companies.Request;
using fashionDesignAPI.Interfaces.Services;

using Microsoft.AspNetCore.Mvc;

namespace fashionDesignAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesService _service;

        public CompaniesController(ICompaniesService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] PostCompanies company)
        {
            var result = await _service.CreateAsync(company);

            return Created("companies", result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var changer = (UsersResponse)HttpContext.Items["User"]!;
            return Ok(await _service.GetByIdAsync(changer.CompanyId));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PutCompanies company)
        {
            return Ok(await _service.UpdateAsync(id, company));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await _service.DeleteAsync(id));
        }
    }
}



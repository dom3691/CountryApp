using CountryApp.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneInfoController : ControllerBase
    {
        private readonly IPhoneInfoService phoneInfoService;

        public PhoneInfoController(IPhoneInfoService phoneInfoService)
        {
            this.phoneInfoService = phoneInfoService;
        }

        [HttpGet]
        public IActionResult GetCountryInfo(string phoneNumber)
        {
            var result = phoneInfoService.GetCountryInfo(phoneNumber);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound("Country not found for the given phone number.");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models.DTOs.CityDTOs;

namespace StrategeRisk.WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cities = await _cityService.GetAsync();

            return Ok(cities.Select(x => new CityDTO
            {
                Id = x.Id,
                Name = x.Name
            }));
        }
    }
}

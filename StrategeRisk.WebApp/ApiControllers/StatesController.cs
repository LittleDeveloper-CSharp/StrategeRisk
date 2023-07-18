using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models.DTOs.StateDTOs;

namespace StrategeRisk.WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateService _stateService;

        public StatesController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var states = await _stateService.GetAsync();

            return Ok(states.Select(x => new StateDTO
            {
                Id = x.Id,
                Name = x.Name,
            }));
        }
    }
}

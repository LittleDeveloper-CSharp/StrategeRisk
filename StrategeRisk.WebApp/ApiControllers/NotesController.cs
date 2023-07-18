using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models.DTOs.NoteDTOs;

namespace StrategeRisk.WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(NoteCreateDTO model)
        {
            var note = new Note
            {
                InvoiceNumber = model.InvoiceNumber,
                EmployeeId = model.EmployeeId,
            };

            var hasCreated = await _noteService.CreateAsync(model.CompanyId, note);
            if (hasCreated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _noteService.DeleteAsync(id);

            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TacheAPI.Models;
using TacheAPI.Services;

namespace TacheAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TacheController: ControllerBase
    {
        private readonly ITacheService _tacheService;
        public TacheController(ITacheService tacheService)
        {
            _tacheService = tacheService;
        }


        [HttpPost]
        public async Task<ActionResult<Tache>> CreateTacheAsync(Tache tache)
        {
            var created = await _tacheService.CreateTacheAsync(tache);

            if (created == null)
                return BadRequest();

            return CreatedAtRoute("GetTacheById", new { id = created.Id }, created );
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTacheAsync(int id)
        {
            if(id <= 0) return BadRequest();
            bool effectuer = await _tacheService.DeleteTacheAsync(id);
            if(!effectuer) return NotFound();
            return NoContent();

        }

        [HttpPut("{id}")]
        public async Task<ActionResult>  UpdateTacheAsync(int id, Tache tache)
        {
            if(id<= 0) return BadRequest();
            bool effectuer = await _tacheService.UpdateTacheAsync(id, tache);
            if(!effectuer) return NotFound();
            return NoContent();

        }

        [HttpGet("{id}", Name = "GetTacheById")]
        public async Task<ActionResult<Tache>> GetTacheByIdAsync(int id)
        {
            if (id <= 0) return BadRequest();
            var tache = await _tacheService.GetTacheByIdAsync(id);
            if (tache == null) return NotFound();
            return Ok(tache);
        }

        [HttpGet]
        public async Task<ActionResult<List<Tache>>> GetAllTachesAsync()
        {
            List<Tache> allTaches = await _tacheService.GetAllTachesAsync();
            return Ok(allTaches);
        }

        [HttpPost("{id}/finish")]
        public async Task<ActionResult> MakeFinishAsync(int id)
        {
            if(id <= 0) return BadRequest();
            bool effectuer = await _tacheService.MakeFinishAsync(id);
            if(!effectuer) return NotFound();
            return NoContent();
        }

    }
    // est ce complet? =>
}

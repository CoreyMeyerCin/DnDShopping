using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DungeonsAndDragons.Model;

namespace DungeonsAndDragons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralStoresController : ControllerBase
    {
        private readonly AppDbcontext _context;

        public GeneralStoresController(AppDbcontext context)
        {
            _context = context;
        }

        // GET: api/GeneralStores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralStore>>> GetGeneralStores()
        {
            return await _context.GeneralStores.ToListAsync();
        }

        // GET: api/GeneralStores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralStore>> GetGeneralStore(int id)
        {
            var generalStore = await _context.GeneralStores.FindAsync(id);

            if (generalStore == null)
            {
                return NotFound();
            }

            return generalStore;
        }

        // PUT: api/GeneralStores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneralStore(int id, GeneralStore generalStore)
        {
            if (id != generalStore.Id)
            {
                return BadRequest();
            }

            _context.Entry(generalStore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneralStoreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GeneralStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GeneralStore>> PostGeneralStore(GeneralStore generalStore)
        {
            _context.GeneralStores.Add(generalStore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneralStore", new { id = generalStore.Id }, generalStore);
        }

        // DELETE: api/GeneralStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeneralStore(int id)
        {
            var generalStore = await _context.GeneralStores.FindAsync(id);
            if (generalStore == null)
            {
                return NotFound();
            }

            _context.GeneralStores.Remove(generalStore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeneralStoreExists(int id)
        {
            return _context.GeneralStores.Any(e => e.Id == id);
        }
    }
}

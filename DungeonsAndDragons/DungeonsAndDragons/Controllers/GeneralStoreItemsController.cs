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
    public class GeneralStoreItemsController : ControllerBase
    {
        private readonly AppDbcontext _context;

        public GeneralStoreItemsController(AppDbcontext context)
        {
            _context = context;
        }

        // GET: api/GeneralStoreItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralStoreItems>>> GetGeneralStoresItems()
        {
            return await _context.GeneralStoresItems.ToListAsync();
        }

        // GET: api/GeneralStoreItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralStoreItems>> GetGeneralStoreItems(int id)
        {
            
            var generalStoreItems = await _context.GeneralStoresItems.FindAsync(id);

            if (generalStoreItems == null)
            {
                return NotFound();
            }

            return generalStoreItems;
        }

        // PUT: api/GeneralStoreItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneralStoreItems(int id, GeneralStoreItems generalStoreItems)
        {
            if (id != generalStoreItems.Id)
            {
                return BadRequest();
            }

            _context.Entry(generalStoreItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneralStoreItemsExists(id))
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

        // POST: api/GeneralStoreItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GeneralStoreItems>> PostGeneralStoreItems(GeneralStoreItems generalStoreItems)
        {
            _context.GeneralStoresItems.Add(generalStoreItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneralStoreItems", new { id = generalStoreItems.Id }, generalStoreItems);
        }

        // DELETE: api/GeneralStoreItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeneralStoreItems(int id)
        {
            var generalStoreItems = await _context.GeneralStoresItems.FindAsync(id);
            if (generalStoreItems == null)
            {
                return NotFound();
            }

            _context.GeneralStoresItems.Remove(generalStoreItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeneralStoreItemsExists(int id)
        {
            return _context.GeneralStoresItems.Any(e => e.Id == id);
        }
    }
}

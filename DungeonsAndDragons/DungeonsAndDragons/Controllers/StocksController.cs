
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
    public class StocksController : ControllerBase
    {
        private readonly AppDbcontext _context;

        public StocksController(AppDbcontext context)
        {
            _context = context;
        }
       
       

        // GET: api/Stocks
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Stock>>> GetStocks(IEnumerable<Item> itemId)
        //{
        //    int count = 0;
        //    List<Item> items = _context.Items.ToList();
            
        //    return 
        //}

        //private async Task<IActionResult> RecalculateRequestTotal(int requestId)
        //{
        //    var request = _context.Requests.Find(requestId);

        //    request.Total = (from rl in _context.RequestLines
        //                     join p in _context.Products
        //                     on rl.ProductId equals p.Id
        //                     where rl.RequestId == requestId
        //                     select new
        //                     {
        //                         LineTotal = rl.Quantity * p.Price
        //                     }).Sum(x => x.LineTotal);
        //    request.Status = "CHANGED";
        //    await _context.SaveChangesAsync();
        //    return Ok();
        //}


        // GET: api/Stocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStock(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);

            if (stock == null)
            {
                return NotFound();
            }

            return stock;
        }

        // PUT: api/Stocks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStock(int id, Stock stock)
        {
            if (id != stock.Id)
            {
                return BadRequest();
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockExists(id))
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

        // POST: api/Stocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStock", new { id = stock.Id }, stock);
        }

        // DELETE: api/Stocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }

            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StockExists(int id)
        {
            return _context.Stocks.Any(e => e.Id == id);
        }
    }
}

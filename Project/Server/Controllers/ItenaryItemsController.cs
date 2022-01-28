using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server.Data;
using Project.Server.IRepository;
using Project.Shared.Domains;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItenaryItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IUnitOfWork _unitOfWork;

        public ItenaryItemsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/ItenaryItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItenaryItem>>> GetItenaryItems()
        {
            return await _context.ItenaryItems.ToListAsync();
        }

        // GET: api/ItenaryItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItenaryItem>> GetItenaryItem(int id)
        {
            var itenaryItem = await _context.ItenaryItems.FindAsync(id);

            if (itenaryItem == null)
            {
                return NotFound();
            }

            return itenaryItem;
        }

        // PUT: api/ItenaryItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItenaryItem(int id, ItenaryItem itenaryItem)
        {
            if (id != itenaryItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(itenaryItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItenaryItemExists(id))
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

        // POST: api/ItenaryItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItenaryItem>> PostItenaryItem(ItenaryItem itenaryItem)
        {
            _context.ItenaryItems.Add(itenaryItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItenaryItem", new { id = itenaryItem.Id }, itenaryItem);
        }

        // DELETE: api/ItenaryItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItenaryItem(int id)
        {
            var itenaryItem = await _context.ItenaryItems.FindAsync(id);
            if (itenaryItem == null)
            {
                return NotFound();
            }

            _context.ItenaryItems.Remove(itenaryItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItenaryItemExists(int id)
        {
            return _context.ItenaryItems.Any(e => e.Id == id);
        }
    }
}

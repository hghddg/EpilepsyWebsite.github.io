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
    public class ItenariesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ItenariesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Itenaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Itenary>>> GetItenaries()
        {
            return await _context.Itenaries.ToListAsync();
        }

        // GET: api/Itenaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Itenary>> GetItenary(int id)
        {
            var itenary = await _context.Itenaries.FindAsync(id);

            if (itenary == null)
            {
                return NotFound();
            }

            return itenary;
        }

        // PUT: api/Itenaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItenary(int id, Itenary itenary)
        {
            if (id != itenary.Id)
            {
                return BadRequest();
            }

            _context.Entry(itenary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItenaryExists(id))
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

        // POST: api/Itenaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Itenary>> PostItenary(Itenary itenary)
        {
            _context.Itenaries.Add(itenary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItenary", new { id = itenary.Id }, itenary);
        }

        // DELETE: api/Itenaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItenary(int id)
        {
            var itenary = await _context.Itenaries.FindAsync(id);
            if (itenary == null)
            {
                return NotFound();
            }

            _context.Itenaries.Remove(itenary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItenaryExists(int id)
        {
            return _context.Itenaries.Any(e => e.Id == id);
        }
    }
}

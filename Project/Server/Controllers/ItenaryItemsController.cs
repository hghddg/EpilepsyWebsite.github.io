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
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ItenaryItemsController(ApplicationDbContext context)
        public ItenaryItemsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/ItenaryItems
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<ItenaryItem>>> GetItenaryItems()
        public async Task<IActionResult> GetItenaryItems()
        {
            //Refactored
            //return await _context.ItenaryItems.ToListAsync();
            var ItenaryItems = await _unitOfWork.ItenaryItems.GetAll(includes: q => q.Include(x => x.Attraction).Include(x => x.Hotel).Include(x => x.Location).Include(x => x.Country).Include(x => x.Payment));
            return Ok(ItenaryItems);
            
        }

        // GET: api/ItenaryItems/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<ItenaryItem>> GetItenaryItem(int id)
        public async Task<IActionResult> GetItenaryItem(int id)
        {
            //Refactored
            //var ItenaryItem = await _context.ItenaryItems.FindAsync(id);
            var ItenaryItem = await _unitOfWork.ItenaryItems.Get(q => q.Id == id);

            if (ItenaryItem == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(ItenaryItem);
        }

        // PUT: api/ItenaryItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItenaryItem(int id, ItenaryItem ItenaryItem)
        {
            if (id != ItenaryItem.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(ItenaryItem).State = EntityState.Modified;
            _unitOfWork.ItenaryItems.Update(ItenaryItem);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ItenaryItemExists(id))
                if (!await ItenaryItemExists(id))
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
        public async Task<ActionResult<ItenaryItem>> PostItenaryItem(ItenaryItem ItenaryItem)
        {
            //Refactored
            //_context.ItenaryItems.Add(ItenaryItem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ItenaryItems.Insert(ItenaryItem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetItenaryItem", new { id = ItenaryItem.Id }, ItenaryItem);
        }

        // DELETE: api/ItenaryItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItenaryItem(int id)
        {
            //Refactored
            //var ItenaryItem = await _context.ItenaryItems.FindAsync(id);
            var ItenaryItem = await _unitOfWork.ItenaryItems.Get(q => q.Id == id);
            if (ItenaryItem == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.ItenaryItems.Remove(ItenaryItem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ItenaryItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool ItenaryItemExists(int id)
        private async Task<bool> ItenaryItemExists(int id)
        {
            //Refactored
            //return _context.ItenaryItems.Any(e => e.Id == id);
            var ItenaryItem = await _unitOfWork.ItenaryItems.Get(q => q.Id == id);
            return ItenaryItem != null;
        }
    }
}

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
        
        private readonly IUnitOfWork _unitOfWork;

        public ItenaryItemsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/ItenaryItems
        [HttpGet]
        public async Task<ActionResult> GetItenaryItems()
        {
            var itenaryitems = await _unitOfWork.ItenaryItems.GetAll(includes: q => q.Include(x => x.Country).Include(x => x.Location).Include(x => x.Attraction).Include(x => x.Hotel));

            return Ok(itenaryitems);
        }

        // GET: api/ItenaryItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetItenaryItem(int id)
        {
            var itenaryItem = await _unitOfWork.ItenaryItems.Get(q => q.Id == id);

            if (itenaryItem == null)
            {
                return NotFound();
            }

            return Ok(itenaryItem);
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

            _unitOfWork.ItenaryItems.Update(itenaryItem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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
        public async Task<ActionResult<ItenaryItem>> PostItenaryItem(ItenaryItem itenaryItem)
        {
            await _unitOfWork.ItenaryItems.Insert(itenaryItem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetItenaryItem", new { id = itenaryItem.Id }, itenaryItem);
        }

        // DELETE: api/ItenaryItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItenaryItem(int id)
        {
            var itenaryItem = await _unitOfWork.ItenaryItems.Get(q => q.Id == id);
            if (itenaryItem == null)
            {
                return NotFound();
            }

            await _unitOfWork.ItenaryItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ItenaryItemExists(int id)
        {
            var itenaryItem = await _unitOfWork.ItenaryItems.Get(q => q.Id == id);
            return itenaryItem != null;
        }
    }
}

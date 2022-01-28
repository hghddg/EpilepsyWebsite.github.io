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
        
        private readonly IUnitOfWork _unitOfWork;

        public ItenariesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Itenaries
        [HttpGet]
        public async Task<ActionResult> GetItenaries()
        {
            var itenaries = await _unitOfWork.Itenaries.GetAll();
            return Ok(itenaries);
        }

        // GET: api/Itenaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetItenary(int id)
        {
            var itenary = await _unitOfWork.Itenaries.Get(q => q.Id == id);

            if (itenary == null)
            {
                return NotFound();
            }

            return Ok(itenary);
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

            _unitOfWork.Itenaries.Update(itenary);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ItenaryExists(id))
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
            await _unitOfWork.Itenaries.Insert(itenary);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetItenary", new { id = itenary.Id }, itenary);
        }

        // DELETE: api/Itenaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItenary(int id)
        {
            var itenary = await _unitOfWork.Itenaries.Get(q => q.Id == id);
            if (itenary == null)
            {
                return NotFound();
            }

            await _unitOfWork.Itenaries.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ItenaryExists(int id)
        {
            var itenary = await _unitOfWork.Itenaries.Get(q => q.Id == id);
            return itenary != null;
        }
    }
}

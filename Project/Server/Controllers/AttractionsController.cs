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
    public class AttractionsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public AttractionsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Attractions
        [HttpGet]        
        public async Task<ActionResult> GetAttractions()
        {
            var attractions = await _unitOfWork.Attractions.GetAll();
            return Ok(attractions);
        }


        // GET: api/Attractions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Attraction>> GetAttraction(int id)
        {
            var attraction = await _unitOfWork.Attractions.Get(q => q.Id == id);

            if (attraction == null)
            {
                return NotFound();
            }

            return attraction;
        }

        // PUT: api/Attractions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttraction(int id, Attraction attraction)
        {
            if (id != attraction.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Attractions.Update(attraction);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AttractionExists(id))
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

        // POST: api/Attractions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Attraction>> PostAttraction(Attraction attraction)
        {
            await _unitOfWork.Attractions.Insert(attraction);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAttraction", new { id = attraction.Id }, attraction);
        }

        // DELETE: api/Attractions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttraction(int id)
        {
            var attraction = await _unitOfWork.Attractions.Get(q => q.Id == id);
            if (attraction == null)
            {
                return NotFound();
            }

            await _unitOfWork.Attractions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AttractionExists(int id)
        {
            var attraction = await _unitOfWork.Attractions.Get(q => q.Id == id);
            return attraction != null;
        }
    }
}

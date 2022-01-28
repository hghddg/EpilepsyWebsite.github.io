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
    public class HotelsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public HotelsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult> GetHotels()
        {
            var hotels = await _unitOfWork.Hotels.GetAll();
            return Ok(hotels);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetHotel(int id)
        {
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);

            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Hotels.Update(hotel);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await HotelExists(id))
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

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            await _unitOfWork.Hotels.Insert(hotel);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            await _unitOfWork.Hotels.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> HotelExists(int id)
        {
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);
            return hotel != null;
        }
    }
}

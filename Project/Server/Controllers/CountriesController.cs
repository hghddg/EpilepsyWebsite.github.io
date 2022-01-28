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
    public class CountriesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public CountriesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult> GetCountry()
        {
            var country = await _unitOfWork.Countries.GetAll();
            return Ok(country);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCountry(int id)
        {
            var country = await _unitOfWork.Countries.Get(q => q.Id == id);

            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, Country country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Countries.Update(country);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CountryExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            await _unitOfWork.Countries.Insert(country); 
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _unitOfWork.Countries.Get(q => q.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            await _unitOfWork.Countries.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CountryExists(int id)
        {
            var country = await _unitOfWork.Countries.Get(q => q.Id == id);
            return country != null;
        }
    }
}

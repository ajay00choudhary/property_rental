using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using property_rental.Data;
using property_rental.model;

namespace property_rental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class propery_detailsController : ControllerBase
    {
        private readonly property_rentalContext _context;

        public propery_detailsController(property_rentalContext context)
        {
            _context = context;
        }

        // GET: api/propery_details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<propery_details>>> Getpropery_details()
        {
            return await _context.propery_details.ToListAsync();
        }

        // GET: api/propery_details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<propery_details>> Getpropery_details(int id)
        {
            var propery_details = await _context.propery_details.FindAsync(id);

            if (propery_details == null)
            {
                return NotFound();
            }

            return propery_details;
        }

        // PUT: api/propery_details/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putpropery_details(int id, propery_details propery_details)
        {
            if (id != propery_details.property_id)
            {
                return BadRequest();
            }

            _context.Entry(propery_details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!propery_detailsExists(id))
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

        // POST: api/propery_details
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<propery_details>> Postpropery_details(propery_details propery_details)
        {
            _context.propery_details.Add(propery_details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getpropery_details", new { id = propery_details.property_id }, propery_details);
        }

        // DELETE: api/propery_details/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<propery_details>> Deletepropery_details(int id)
        {
            var propery_details = await _context.propery_details.FindAsync(id);
            if (propery_details == null)
            {
                return NotFound();
            }

            _context.propery_details.Remove(propery_details);
            await _context.SaveChangesAsync();

            return propery_details;
        }

        private bool propery_detailsExists(int id)
        {
            return _context.propery_details.Any(e => e.property_id == id);
        }
    }
}

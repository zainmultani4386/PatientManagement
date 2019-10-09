using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientManagement.Models;

namespace PatientManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientDetailsController : ControllerBase
    {
        private readonly PatientManagementContext _context;

        public PatientDetailsController(PatientManagementContext context)
        {
            _context = context;
        }

        // GET: api/PatientDetails
        [HttpGet]
        public IEnumerable<PatientDetail> GetPatientDetail()
        {
            return _context.PatientDetail;
        }

        // GET: api/PatientDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patientDetail = await _context.PatientDetail.FindAsync(id);

            if (patientDetail == null)
            {
                return NotFound();
            }

            return Ok(patientDetail);
        }

        // PUT: api/PatientDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientDetail([FromRoute] int id, [FromBody] PatientDetail patientDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patientDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(patientDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientDetailExists(id))
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

        // POST: api/PatientDetails
        [HttpPost]
        public async Task<IActionResult> PostPatientDetail([FromBody] PatientDetail patientDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PatientDetail.Add(patientDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientDetail", new { id = patientDetail.Id }, patientDetail);
        }

        // DELETE: api/PatientDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patientDetail = await _context.PatientDetail.FindAsync(id);
            if (patientDetail == null)
            {
                return NotFound();
            }

            _context.PatientDetail.Remove(patientDetail);
            await _context.SaveChangesAsync();

            return Ok(patientDetail);
        }

        private bool PatientDetailExists(int id)
        {
            return _context.PatientDetail.Any(e => e.Id == id);
        }
    }
}
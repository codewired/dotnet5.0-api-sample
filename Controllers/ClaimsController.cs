using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.Data;
using SampleWebAPI.Data.Repository;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly IClaimsRepository _repository;

        public ClaimsController(IClaimsRepository repository, AppDBContext context)
        {
            _context = context;
            _repository = repository;
        }

        // GET: api/Claims
        [HttpGet]
        public ActionResult<List<Claim>> GetClaims(bool includeMembers = true)
        {
            List<Claim> claims;
            try
            {

                claims = _repository.GetAllClaims(includeMembers);
                return claims;

                
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get orders : {ex}");
            }
        }
    

        // GET: api/Claims/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Claim>> GetClaim(int id)
        {
            var claim = await _context.Claims.FindAsync(id);

            if (claim == null)
            {
                return NotFound();
            }

            return claim;
        }

        // PUT: api/Claims/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClaim(int id, Claim claim)
        {
            if (id != claim.Id)
            {
                return BadRequest();
            }

            _context.Entry(claim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimExists(id))
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

        // POST: api/Claims
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Claim>> PostClaim(Claim claim)
        {
            _context.Claims.Add(claim);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClaimExists(claim.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetClaim), new { id = claim.Id }, claim);
        }

        // DELETE: api/Claims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClaim(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound();
            }

            _context.Claims.Remove(claim);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClaimExists(int id)
        {
            return _context.Claims.Any(e => e.Id == id);
        }
    }
}

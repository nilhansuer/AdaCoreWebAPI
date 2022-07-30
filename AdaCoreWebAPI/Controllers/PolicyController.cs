using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdaCoreWebAPI.Context;
using AdaCoreWebAPI.Domains;

namespace AdaCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly AdaDbContext _context;

        public PolicyController(AdaDbContext context)
        {
            _context = context;
        }

        // GET: api/Policy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Policy>>> GetPolicies()
        {
            return await _context.Policies.ToListAsync();
        }

        // GET: api/Policy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Policy>> GetPolicy(string id)
        {
            var policy = await _context.Policies.FindAsync(id);

            if (policy == null)
            {
                return NotFound();
            }

            return policy;
        }

        // PUT: api/Policy/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPolicy(string id, Policy policy)
        {
            if (id != policy.PolicyNo)
            {
                return BadRequest();
            }

            _context.Entry(policy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolicyExists(id))
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

        // POST: api/Policy
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Policy>> PostPolicy(Policy policy)
        {
            _context.Policies.Add(policy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PolicyExists(policy.PolicyNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPolicy", new { id = policy.PolicyNo }, policy);
        }

        // DELETE: api/Policy/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Policy>> DeletePolicy(string id)
        {
            var policy = await _context.Policies.FindAsync(id);
            if (policy == null)
            {
                return NotFound();
            }

            _context.Policies.Remove(policy);
            await _context.SaveChangesAsync();

            return policy;
        }

        private bool PolicyExists(string id)
        {
            return _context.Policies.Any(e => e.PolicyNo == id);
        }
    }
}

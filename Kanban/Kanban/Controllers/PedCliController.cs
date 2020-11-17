using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanban.Server.DataAccess;
using Kanban.Shared.Models;

namespace Kanban.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedCliController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedCliController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PedCli
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedCli>>> GetPedCli()
        {
            return await _context.PedCli.ToListAsync();
        }

        // GET: api/PedCli/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PedCli>> GetPedCli(int id)
        {
            var PedCli = await _context.PedCli.FindAsync(id);

            if (PedCli == null)
            {
                return NotFound();
            }

            return PedCli;
        }

        // PUT: api/Estado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedCli(int id, PedCli PedCli)
        {
            if (id != PedCli.Id)
            {
                return BadRequest();
            }

            _context.Entry(PedCli).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedCliExists(id))
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

        // POST: api/PedCli
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PedCli>> PostPedCli(PedCli PedCli)
        {
            _context.PedCli.Add(PedCli);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PedCliExists(PedCli.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPedCli", new { id = PedCli.Id }, PedCli);
        }

        // DELETE: api/PedCli/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PedCli>> DeletePedCli(int id)
        {
            var PedCli = await _context.PedCli.FindAsync(id);
            if (PedCli == null)
            {
                return NotFound();
            }

            _context.PedCli.Remove(PedCli);
            await _context.SaveChangesAsync();

            return PedCli;
        }

        private bool PedCliExists(int id)
        {
            return _context.PedCli.Any(e => e.Id == id);
        }
    }
}
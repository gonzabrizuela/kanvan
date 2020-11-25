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
    public class LogisticaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LogisticaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/LOGISTICA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LOGISTICA>>> GetEstado()
        {
            return await _context.LOGISTICA.ToListAsync();
        }

        // GET: api/LOGISTICA/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LOGISTICA>> GetLOGISTICA(int PEDIDO)
        {
            var LOGISTICA = await _context.LOGISTICA.FindAsync(PEDIDO);

            if (LOGISTICA == null)
            {
                return NotFound();
            }

            return LOGISTICA;
        }

        // PUT: api/Estado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLOGISTICA(int Id, LOGISTICA LOGISTICA)
        {
            if (Id != LOGISTICA.Id)
            {
                return BadRequest();
            }

            _context.Entry(LOGISTICA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LOGISTICAExists(Id))
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

        // POST: api/LOGISTICA
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LOGISTICA>> PostLOGISTICA(LOGISTICA LOGISTICA)
        {
            _context.LOGISTICA.Add(LOGISTICA);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LOGISTICAExists(LOGISTICA.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLOGISTICA", new { Id = LOGISTICA.Id }, LOGISTICA);
        }

        // DELETE: api/Estado/5
        [HttpDelete("{PEDIDO}")]
        public async Task<ActionResult<LOGISTICA>> DeleteLOGISTICA(int Id)
        {
            var LOGISTICA = await _context.LOGISTICA.FindAsync(Id);
            if (LOGISTICA == null)
            {
                return NotFound();
            }

            _context.LOGISTICA.Remove(LOGISTICA);
            await _context.SaveChangesAsync();

            return LOGISTICA;
        }

        private bool LOGISTICAExists(int Id)
        {
            return _context.LOGISTICA.Any(e => e.Id == Id);
        }
    }
}
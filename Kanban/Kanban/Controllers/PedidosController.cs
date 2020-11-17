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
    public class PedidosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedidos>>> GetEstado()
        {
            return await _context.Pedidos.ToListAsync();
        }

        // GET: api/Pedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedidos>> GetPedidos(int PEDIDO)
        {
            var Pedidos = await _context.Pedidos.FindAsync(PEDIDO);

            if (Pedidos == null)
            {
                return NotFound();
            }

            return Pedidos;
        }

        // PUT: api/Estado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedidos(int PEDIDO, Pedidos Pedidos)
        {
            if (PEDIDO != Pedidos.PEDIDO)
            {
                return BadRequest();
            }

            _context.Entry(Pedidos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidosExists(PEDIDO))
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

        // POST: api/Pedidos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pedidos>> PostPedidos(Pedidos Pedidos)
        {
            _context.Pedidos.Add(Pedidos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PedidosExists(Pedidos.PEDIDO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPedidos", new { PEDIDO = Pedidos.PEDIDO }, Pedidos);
        }

        // DELETE: api/Estado/5
        [HttpDelete("{PEDIDO}")]
        public async Task<ActionResult<Pedidos>> DeletePedidos(int PEDIDO)
        {
            var Pedidos = await _context.Pedidos.FindAsync(PEDIDO);
            if (Pedidos == null)
            {
                return NotFound();
            }

            _context.Pedidos.Remove(Pedidos);
            await _context.SaveChangesAsync();

            return Pedidos;
        }

        private bool PedidosExists(int PEDIDO)
        {
            return _context.Pedidos.Any(e => e.PEDIDO == PEDIDO);
        }
    }
}
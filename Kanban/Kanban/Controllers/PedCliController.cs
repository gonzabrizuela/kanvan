using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Kanban.Server.DataAccess;
using Kanban.Shared.Models;
namespace Kanban
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

        [HttpGet]
        public IEnumerable<PedCli> Get(string PEDIDO)
        {
            string xSQL = string.Format("SELECT Pedcli.* FROM((Pedcli INNER JOIN Programa ON Pedcli.PEDIDO = Programa.PEDIDO) INNER JOIN Pedidos ON pedcli.PEDIDO = Pedidos.PEDIDO) where(pedidos.FLAG = 0 AND Programa.CG_ESTADO = 3 AND Pedidos.CG_ORDF != 0 AND(Pedidos.TIPOO = 1))  ORDER BY Pedcli.PEDIDO DESC");
            return _context.PedCli.FromSqlRaw(xSQL).ToList<PedCli>();
        }
    }
}
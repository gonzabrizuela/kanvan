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
namespace Kanban.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PruebaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PedCli> Get(string CAMPO)
        {
            try
            {
                string xSQL = string.Format("SELECT Pedcli.PEDIDO, Programa.CG_ESTADO, Pedidos.REMITO, Programa.CG_ESTADOCARGA, Pedidos.FLAG, Pedidos.CG_ORDF, Programa.FE_CIERRE, Pedidos.TIPOO, Pedidos.CG_TIRE FROM((PedcliINNER JOIN Programa ON Pedcli.PEDIDO = Programa.PEDIDO) INNER JOIN Pedidos ON pedcli.PEDIDO = Pedidos.PEDIDO) where(pedidos.FLAG = 0 AND Programa.CG_ESTADO = 3 AND Pedidos.CG_ORDF != 0 AND(Pedidos.TIPOO = 1))  ORDER BY PEDIDO DESC");
                return _context.Solution.FromSqlRaw(xSQL).ToList<PedCli>();
            }
            catch
            {
                return new List<PedCli>();
            }
        }
    }
}
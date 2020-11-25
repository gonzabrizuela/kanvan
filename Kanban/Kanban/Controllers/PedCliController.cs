﻿using System;
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
            try
            {
                string xSQL = string.Format("SELECT PEDIDO, ORCO from pedcli");
                return _context.PedCli.FromSqlRaw(xSQL).ToList<PedCli>();
            }
            catch
            {
                return new List<PedCli>();
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Kanban.Server.DataAccess;
//using Kanban.Shared.Models;
//namespace Kanban
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class KanbanLOGController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public KanbanLOGController(AppDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public IEnumerable<KanbanLOG> Get(string PEDIDO)
//        {
//            string xSQL = string.Format("select * from KanbanLOG");
//            return _context.KanbanLOG.FromSqlRaw(xSQL).ToList<KanbanLOG>();
//        }
//    }
//}
using Kanban;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanban.Shared.Models;

namespace Kanban.Server.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<PedCli> PedCli { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<LOGISTICA> LOGISTICA { get; set; }
        public DbSet<PedCli> Prueba { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

    }
}

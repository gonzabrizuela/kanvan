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
        public DbSet<Programa> Programa { get; set; }
        //public DbSet<KanbanLOG> KanbanLOG { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<KanbanLOG>(eb =>
        //        {
        //            eb.HasNoKey();
        //            eb.ToView("KanbanLOG");
        //            eb.Property(v => v.PEDIDO).HasColumnName("PEDIDO");
        //        });
        //}
    }
}

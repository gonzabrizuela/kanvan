﻿using Kanban;
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
        public DbSet<Trabajosefec> Trabajosefec { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

    }
}
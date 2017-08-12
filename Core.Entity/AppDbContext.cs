using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Thing> Things { get; set; }
    }

    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using Lab1Web.Enitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1Web.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ItemEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}

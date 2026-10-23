using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.entities
{
    internal class aplicação_financeiraDbContext : DbContext
    {
        public DbSet <aplicação_financeira> aplicação_financeiraS { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
    }
    

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Week2Deel1
{
    public class HuisenContext : DbContext
    {
        public DbSet<Huis> Huisen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Week2Deel2;Trusted_Connection=True;");
        }
    }
}

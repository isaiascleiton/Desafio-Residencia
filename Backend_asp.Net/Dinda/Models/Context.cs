using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinda.Models
{
    public class Context : DbContext
    {
        public DbSet<Madrinha> Madrinhas { get; set; }
        public DbSet<Afilhada> Afilhadas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Dinda;Integrated Security=True");
        }
    }
}

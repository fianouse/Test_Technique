using last_test_tech.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace last_test_tech.Data
{
    public class candidaturedb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Last_DB;Trusted_Connection=True;");
        }
        public DbSet<Candidat> candidatures { get; set; }
    }
}

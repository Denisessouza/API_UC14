using Microsoft.EntityFrameworkCore;
using ExoApi.Models;
using System.Security.Cryptography.X509Certificates;

namespace ExoApi.Contexts
{
    public class dbExoApi_Context : DbContext
    {

        public dbExoApi_Context()
        {
        }
        public dbExoApi_Context(DbContextOptions<dbExoApi_Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DENISE-SOUZA\\SQLEXPRESS initial catalog =db_exo");

            }

            
        }
            public DbSet <Projeto> Projeto { get; set; }
    }
}

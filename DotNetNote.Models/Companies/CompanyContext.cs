using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models.Companies
{
    public class CompanyContext : DbContext
    {
        private string _connectionString;

        public CompanyContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public CompanyContext(DbContextOptions<CompanyContext> options) :base(options)
        {

        }

        public DbSet<CompanyModel> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            //base.OnConfiguring(optionsBuilder);
        }
    }
}

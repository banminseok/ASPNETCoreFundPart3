using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace IdeaApp.Models
{
    public class IdeaAppDbContext : DbContext
    {
        public IdeaAppDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "ConnectionString"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }

            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Idea> Ideas { get; set; }
    }
}

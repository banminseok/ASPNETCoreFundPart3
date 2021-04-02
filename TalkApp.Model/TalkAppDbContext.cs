using Microsoft.EntityFrameworkCore;
using TalkApp.Models;

namespace TalkApp.Model
{
    /// <summary>
    /// 연결할 DB와 1대1로 보면 된다.
    /// </summary>
    public class TalkAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //연결 문자열 - Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

            //optionsBuilder.UseInMemoryDatabase("TalkApp");
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=TalkApp;Integrated Security=True;"); //real DB
        }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<TalkComment> TalkComments { get; set; }
    }

}

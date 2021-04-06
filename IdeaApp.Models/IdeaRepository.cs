using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace IdeaApp.Models
{
    public class IdeaRepository : IIdeaRepository
    {
        private SqlConnection db;

        public IdeaRepository(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection").ToString());
        }

        public List<Idea> GetAll()
        {
            string sql = @"Select Top 1000 Id, Note From Ideas";
            return db.Query<Idea>(sql).ToList();
        }

        public Idea Add(Idea model)
        {
            string sql = @"
                Insert Into Ideas (Note) Values(@Note);
                Select Cast(SCOPE_IDENTITY() As Int);
            ";
            var id = db.Query<int>(sql, model).Single();
            model.Id = id;
            return model;
        }
    }
}
